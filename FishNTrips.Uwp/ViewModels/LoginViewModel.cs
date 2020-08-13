using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using FishNTrips.Uwp.Helpers;
using Newtonsoft.Json;
using Windows.UI.Xaml.Controls;
using FishNTrips.Model;
using Windows.UI.Xaml;
using FishNTrips.Uwp.Views;
using FishNTrips.Uwp.Services;
using FishNTrips.Uwp.DataAccess;
using Windows.UI.Xaml.Navigation;

namespace FishNTrips.Uwp.ViewModels
{
    /// <seealso cref="FishNTrips.Uwp.Helpers.Observable" />
    public class LoginViewModel : Observable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginViewModel"/> class.
        /// </summary>
        public LoginViewModel() { }

        /// <summary>
        /// The username
        /// </summary>
        public string username;
        /// <summary>
        /// The password
        /// </summary>
        public string password;

        /// <summary>
        /// The users data access
        /// </summary>
        private Users usersDataAccess = new Users();

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();

        /// <summary>
        /// Loads the users asynchronous.
        /// </summary>
        /// <returns></returns>
        internal async Task LoadUsersAsync()
        {
            var users = await usersDataAccess.GetUsersAsync();
            foreach (User user in users)
            {
                Users.Add(user);
            }
        }

        //Giving dialogs for the login fields.
        /// <summary>
        /// Logins this instance.
        /// </summary>
        /// <returns></returns>
        public async Task Login()
        {
            if ((username == null || username == "") && (password == null || password == ""))
            {
                ContentDialog missingPasswordDialog = new ContentDialog
                {
                    Title = "Missing username and password",
                    Content = "Please enter username and password",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await missingPasswordDialog.ShowAsync();
            }

            else if (username == null || username == "")
            {
                ContentDialog missingUsernameDialog = new ContentDialog
                {
                    Title = "No username entered",
                    Content = "Please enter username",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await missingUsernameDialog.ShowAsync();
            }
            else if (password == null || password == "")
            {
                ContentDialog missingPasswordDialog = new ContentDialog
                {
                    Title = "No password entered",
                    Content = "Please enter password",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await missingPasswordDialog.ShowAsync();
            }
            

            else
            {
                bool loginSuccess = false;

                foreach (var u in Users)
                {

                    if (username == u.UserName && password == u.UserPassword)
                    {
                        ContentDialog CorrectUserInformationDialog = new ContentDialog
                        {
                            Title = "Login successful",
                            Content = $"Welcome, {u.UserName}!",
                            CloseButtonText = "Continue"
                        };

                        ContentDialogResult result = await CorrectUserInformationDialog.ShowAsync();

                        NavigationService.Navigate(typeof(HomePage), u);
                        loginSuccess = true;
                        break;
                    }        
                }
                if (loginSuccess == false)
                {
                    ContentDialog WrongUserInformationDialog = new ContentDialog
                    {
                        Title = "Login not successful!",
                        Content = "Check your login information and try again",
                        CloseButtonText = "Ok"
                    };
                    ContentDialogResult result = await WrongUserInformationDialog.ShowAsync();
                }
            }
        }
    }
}
