using System;
using Windows.Devices.Geolocation;

using FishNTrips.Uwp.Helpers;
using FishNTrips.Model;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using Windows.UI.Xaml.Controls;
using FishNTrips.Uwp.DataAccess;
using System.Collections.ObjectModel;

namespace FishNTrips.Uwp.ViewModels
{

    /// <seealso cref="FishNTrips.Uwp.Helpers.Observable" />
    public class HomeViewModel : Observable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HomeViewModel"/> class.
        /// </summary>
        public HomeViewModel()
        {
        }

        /// <summary>
        /// The locations data access
        /// </summary>
        private Locations locationsDataAccess = new Locations();
        /// <summary>
        /// The users data access
        /// </summary>
        private Users usersDataAccess = new Users();

        /// <summary>
        /// Gets or sets the locations.
        /// </summary>
        /// <value>
        /// The locations.
        /// </value>
        public ObservableCollection<Location> Locations { get; set; } = new ObservableCollection<Location>();

        /// <summary>
        /// The logged in
        /// </summary>
        public User LoggedIn;
        /// <summary>
        /// The welcome text
        /// </summary>
        public string WelcomeText;

        /// <summary>
        /// The location name
        /// </summary>
        public string locationName;

        /// <summary>
        /// The new password
        /// </summary>
        public string newPassword;


        /// <summary>
        /// Starts the page.
        /// </summary>
        public void StartPage() {
            WelcomeText = $"Welcome back, {LoggedIn.UserName}";
        }

        /// <summary>
        /// Adds the location.
        /// </summary>
        /// <returns></returns>
        public async Task AddLocation() {
            Location newLocation = new Location
            {
                LocationName = locationName
            };

            if (locationName == "" || locationName == null) {
                ContentDialog noLocationError = new ContentDialog
                {
                    Title = "Error",
                    Content = "Enter new location",
                    CloseButtonText = "Continue"
                };
                ContentDialogResult result = await noLocationError.ShowAsync();
            }

            else if (await locationsDataAccess.PostLocationAsync(newLocation))
            {
                ContentDialog locationOk = new ContentDialog
                {
                    Title = "Success",
                    Content = "Location added",
                    CloseButtonText = "Ok"
                };
                ContentDialogResult result = await locationOk.ShowAsync();
            }
            else {
                ContentDialog locationError = new ContentDialog
                {
                    Title = "Not successful",
                    Content = "Location cant be added",
                    CloseButtonText = "Continue"
                };
                ContentDialogResult result = await locationError.ShowAsync();
            }
        }

        /// <summary>
        /// Loads the locations asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task LoadLocationsAsync()
        {
            var locations = await locationsDataAccess.GetLocationsAsync();
            foreach (Location l in locations)
            {
                Locations.Add(l);
            }
        }

        /// <summary>
        /// Updates the password.
        /// </summary>
        /// <returns></returns>
        public async Task UpdatePassword() {

            LoggedIn.UserPassword = newPassword;

            if (await usersDataAccess.UpdateUserAsync(LoggedIn)) {
                ContentDialog UpdatePasswordDialog = new ContentDialog
                {
                    Title = "Success",
                    Content = "Your password is now changed",
                    CloseButtonText = "Continue"
                };
                ContentDialogResult result = await UpdatePasswordDialog.ShowAsync();
            }
        }

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <returns></returns>
        public async Task DeleteUser() {
            if (await usersDataAccess.DeleteUserAsync(LoggedIn.UserId)) {
                ContentDialog deleteUserOk = new ContentDialog
                {
                    Title = "Success",
                    Content = "User deleted",
                    CloseButtonText = "Ok"
                };
                ContentDialogResult result = await deleteUserOk.ShowAsync();
            }
            
        }
    }
}
