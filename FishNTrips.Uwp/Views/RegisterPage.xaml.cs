using System;

using FishNTrips.Uwp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace FishNTrips.Uwp.Views
{
    /// <seealso cref="Windows.UI.Xaml.Controls.Page" />
    /// <seealso cref="Windows.UI.Xaml.Markup.IComponentConnector" />
    /// <seealso cref="Windows.UI.Xaml.Markup.IComponentConnector2" />
    public sealed partial class RegisterPage : Page
    {
        /// <summary>
        /// Gets the view model.
        /// </summary>
        /// <value>
        /// The view model.
        /// </value>
        public RegisterViewModel ViewModel { get; } = new RegisterViewModel();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterPage"/> class.
        /// </summary>
        public RegisterPage()
        {
            InitializeComponent();
        }
    }
}
