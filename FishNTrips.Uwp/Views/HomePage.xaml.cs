using System;
using FishNTrips.Model;
using FishNTrips.Uwp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace FishNTrips.Uwp.Views
{

    /// <seealso cref="Windows.UI.Xaml.Controls.Page" />
    /// <seealso cref="Windows.UI.Xaml.Markup.IComponentConnector" />
    /// <seealso cref="Windows.UI.Xaml.Markup.IComponentConnector2" />
    public sealed partial class HomePage : Page
    {
        /// <summary>
        /// Gets the view model.
        /// </summary>
        /// <value>
        /// The view model.
        /// </value>
        public HomeViewModel ViewModel { get; } = new HomeViewModel();

        /// <summary>
        /// Initializes a new instance of the <see cref="HomePage"/> class.
        /// </summary>
        public HomePage()
        {
            InitializeComponent();

            Loaded += HomePage_LoadedAsync;
        }

        /// <summary>
        /// Handles the LoadedAsync event of the HomePage control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="Windows.UI.Xaml.RoutedEventArgs"/> instance containing the event data.</param>
        private async void HomePage_LoadedAsync(object sender, Windows.UI.Xaml.RoutedEventArgs e) {
            await ViewModel.LoadLocationsAsync();
        }

        /// <summary>
        /// Invoked when the Page is loaded and becomes the current source of a parent Frame.
        /// </summary>
        /// <param name="e">Event data that can be examined by overriding code. The event data is representative of the pending navigation that will load the current Page. Usually the most relevant property to examine is Parameter.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var user = e.Parameter;
            ViewModel.LoggedIn = (User)user;
            ViewModel.StartPage();
        }

    }
}
