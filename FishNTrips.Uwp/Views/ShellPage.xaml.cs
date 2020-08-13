using System;

using FishNTrips.Uwp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace FishNTrips.Uwp.Views
{
    // TODO WTS: Change the icons and titles for all NavigationViewItems in ShellPage.xaml.

    /// <seealso cref="Windows.UI.Xaml.Controls.Page" />
    /// <seealso cref="Windows.UI.Xaml.Markup.IComponentConnector" />
    /// <seealso cref="Windows.UI.Xaml.Markup.IComponentConnector2" />
    public sealed partial class ShellPage : Page
    {
        /// <summary>
        /// Gets the view model.
        /// </summary>
        /// <value>
        /// The view model.
        /// </value>
        public ShellViewModel ViewModel { get; } = new ShellViewModel();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellPage"/> class.
        /// </summary>
        public ShellPage()
        {
            InitializeComponent();
            DataContext = ViewModel;
            ViewModel.Initialize(shellFrame, navigationView, KeyboardAccelerators);
        }

    }
}
