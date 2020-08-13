using System;
using System.Threading.Tasks;
using System.Windows.Input;

using FishNTrips.Uwp.Helpers;
using FishNTrips.Uwp.Services;

using Windows.ApplicationModel;
using Windows.UI.Xaml;

namespace FishNTrips.Uwp.ViewModels
{
    // TODO WTS: Add other settings as necessary. For help see https://github.com/Microsoft/WindowsTemplateStudio/blob/master/docs/pages/settings.md

    /// <seealso cref="FishNTrips.Uwp.Helpers.Observable" />
    public class SettingsViewModel : Observable
    {
        /// <summary>
        /// The element theme
        /// </summary>
        private ElementTheme _elementTheme = ThemeSelectorService.Theme;

        /// <summary>
        /// Gets or sets the element theme.
        /// </summary>
        /// <value>
        /// The element theme.
        /// </value>
        public ElementTheme ElementTheme
        {
            get { return _elementTheme; }

            set { Set(ref _elementTheme, value); }
        }

        /// <summary>
        /// The version description
        /// </summary>
        private string _versionDescription;

        /// <summary>
        /// Gets or sets the version description.
        /// </summary>
        /// <value>
        /// The version description.
        /// </value>
        public string VersionDescription
        {
            get { return _versionDescription; }

            set { Set(ref _versionDescription, value); }
        }

        /// <summary>
        /// The switch theme command
        /// </summary>
        private ICommand _switchThemeCommand;

        /// <summary>
        /// Gets the switch theme command.
        /// </summary>
        /// <value>
        /// The switch theme command.
        /// </value>
        public ICommand SwitchThemeCommand
        {
            get
            {
                if (_switchThemeCommand == null)
                {
                    _switchThemeCommand = new RelayCommand<ElementTheme>(
                        async (param) =>
                        {
                            ElementTheme = param;
                            await ThemeSelectorService.SetThemeAsync(param);
                        });
                }

                return _switchThemeCommand;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsViewModel"/> class.
        /// </summary>
        public SettingsViewModel()
        {
        }

        /// <summary>
        /// Initializes the asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task InitializeAsync()
        {
            VersionDescription = GetVersionDescription();
            await Task.CompletedTask;
        }

        /// <summary>
        /// Gets the version description.
        /// </summary>
        /// <returns></returns>
        private string GetVersionDescription()
        {
            var appName = "AppDisplayName".GetLocalized();
            var package = Package.Current;
            var packageId = package.Id;
            var version = packageId.Version;

            return $"{appName} - {version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
        }
    }
}
