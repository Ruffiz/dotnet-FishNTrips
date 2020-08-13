using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

using FishNTrips.Uwp.Helpers;
using FishNTrips.Uwp.Services;
using FishNTrips.Uwp.Views;

using Windows.System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

using WinUI = Microsoft.UI.Xaml.Controls;

namespace FishNTrips.Uwp.ViewModels
{
    /// <seealso cref="FishNTrips.Uwp.Helpers.Observable" />
    public class ShellViewModel : Observable
    {
        /// <summary>
        /// The alt left keyboard accelerator
        /// </summary>
        private readonly KeyboardAccelerator _altLeftKeyboardAccelerator = BuildKeyboardAccelerator(VirtualKey.Left, VirtualKeyModifiers.Menu);
        /// <summary>
        /// The back keyboard accelerator
        /// </summary>
        private readonly KeyboardAccelerator _backKeyboardAccelerator = BuildKeyboardAccelerator(VirtualKey.GoBack);

        /// <summary>
        /// The is back enabled
        /// </summary>
        private bool _isBackEnabled;
        /// <summary>
        /// The keyboard accelerators
        /// </summary>
        private IList<KeyboardAccelerator> _keyboardAccelerators;
        /// <summary>
        /// The navigation view
        /// </summary>
        private WinUI.NavigationView _navigationView;
        /// <summary>
        /// The selected
        /// </summary>
        private WinUI.NavigationViewItem _selected;
        /// <summary>
        /// The loaded command
        /// </summary>
        private ICommand _loadedCommand;
        /// <summary>
        /// The item invoked command
        /// </summary>
        private ICommand _itemInvokedCommand;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is back enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is back enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsBackEnabled
        {
            get { return _isBackEnabled; }
            set { Set(ref _isBackEnabled, value); }
        }

        /// <summary>
        /// Gets or sets the selected.
        /// </summary>
        /// <value>
        /// The selected.
        /// </value>
        public WinUI.NavigationViewItem Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }

        /// <summary>
        /// Gets the loaded command.
        /// </summary>
        /// <value>
        /// The loaded command.
        /// </value>
        public ICommand LoadedCommand => _loadedCommand ?? (_loadedCommand = new RelayCommand(OnLoaded));

        /// <summary>
        /// Gets the item invoked command.
        /// </summary>
        /// <value>
        /// The item invoked command.
        /// </value>
        public ICommand ItemInvokedCommand => _itemInvokedCommand ?? (_itemInvokedCommand = new RelayCommand<WinUI.NavigationViewItemInvokedEventArgs>(OnItemInvoked));

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellViewModel"/> class.
        /// </summary>
        public ShellViewModel()
        {
        }

        /// <summary>
        /// Initializes the specified frame.
        /// </summary>
        /// <param name="frame">The frame.</param>
        /// <param name="navigationView">The navigation view.</param>
        /// <param name="keyboardAccelerators">The keyboard accelerators.</param>
        public void Initialize(Frame frame, WinUI.NavigationView navigationView, IList<KeyboardAccelerator> keyboardAccelerators)
        {
            _navigationView = navigationView;
            _keyboardAccelerators = keyboardAccelerators;
            NavigationService.Frame = frame;
            NavigationService.NavigationFailed += Frame_NavigationFailed;
            NavigationService.Navigated += Frame_Navigated;
            _navigationView.BackRequested += OnBackRequested;
        }

        /// <summary>
        /// Called when [loaded].
        /// </summary>
        private async void OnLoaded()
        {
            // Keyboard accelerators are added here to avoid showing 'Alt + left' tooltip on the page.
            // More info on tracking issue https://github.com/Microsoft/microsoft-ui-xaml/issues/8
            _keyboardAccelerators.Add(_altLeftKeyboardAccelerator);
            _keyboardAccelerators.Add(_backKeyboardAccelerator);
            await Task.CompletedTask;
        }

        /// <summary>
        /// Raises the <see cref="E:ItemInvoked" /> event.
        /// </summary>
        /// <param name="args">The <see cref="WinUI.NavigationViewItemInvokedEventArgs"/> instance containing the event data.</param>
        private void OnItemInvoked(WinUI.NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                NavigationService.Navigate(typeof(SettingsPage));
                return;
            }

            var item = _navigationView.MenuItems
                            .OfType<WinUI.NavigationViewItem>()
                            .First(menuItem => (string)menuItem.Content == (string)args.InvokedItem);
            var pageType = item.GetValue(NavHelper.NavigateToProperty) as Type;
            NavigationService.Navigate(pageType);
        }

        /// <summary>
        /// Called when [back requested].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The <see cref="WinUI.NavigationViewBackRequestedEventArgs"/> instance containing the event data.</param>
        private void OnBackRequested(WinUI.NavigationView sender, WinUI.NavigationViewBackRequestedEventArgs args)
        {
            NavigationService.GoBack();
        }

        /// <summary>
        /// Handles the NavigationFailed event of the Frame control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="NavigationFailedEventArgs"/> instance containing the event data.</param>
        private void Frame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw e.Exception;
        }

        /// <summary>
        /// Handles the Navigated event of the Frame control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="NavigationEventArgs"/> instance containing the event data.</param>
        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {
            IsBackEnabled = NavigationService.CanGoBack;
            if (e.SourcePageType == typeof(SettingsPage))
            {
                Selected = _navigationView.SettingsItem as WinUI.NavigationViewItem;
                return;
            }

            Selected = _navigationView.MenuItems
                            .OfType<WinUI.NavigationViewItem>()
                            .FirstOrDefault(menuItem => IsMenuItemForPageType(menuItem, e.SourcePageType));
        }

        /// <summary>
        /// Determines whether [is menu item for page type] [the specified menu item].
        /// </summary>
        /// <param name="menuItem">The menu item.</param>
        /// <param name="sourcePageType">Type of the source page.</param>
        /// <returns>
        ///   <c>true</c> if [is menu item for page type] [the specified menu item]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsMenuItemForPageType(WinUI.NavigationViewItem menuItem, Type sourcePageType)
        {
            var pageType = menuItem.GetValue(NavHelper.NavigateToProperty) as Type;
            return pageType == sourcePageType;
        }

        /// <summary>
        /// Builds the keyboard accelerator.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="modifiers">The modifiers.</param>
        /// <returns></returns>
        private static KeyboardAccelerator BuildKeyboardAccelerator(VirtualKey key, VirtualKeyModifiers? modifiers = null)
        {
            var keyboardAccelerator = new KeyboardAccelerator() { Key = key };
            if (modifiers.HasValue)
            {
                keyboardAccelerator.Modifiers = modifiers.Value;
            }

            keyboardAccelerator.Invoked += OnKeyboardAcceleratorInvoked;
            return keyboardAccelerator;
        }

        /// <summary>
        /// Called when [keyboard accelerator invoked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The <see cref="KeyboardAcceleratorInvokedEventArgs"/> instance containing the event data.</param>
        private static void OnKeyboardAcceleratorInvoked(KeyboardAccelerator sender, KeyboardAcceleratorInvokedEventArgs args)
        {
            var result = NavigationService.GoBack();
            args.Handled = result;
        }
    }
}
