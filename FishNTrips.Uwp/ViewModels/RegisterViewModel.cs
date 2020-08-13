using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FishNTrips.Model;
using FishNTrips.Uwp.DataAccess;
using FishNTrips.Uwp.Helpers;
using FishNTrips.Uwp.Services;
using FishNTrips.Uwp.Views;
using Newtonsoft.Json;
using Windows.UI.Xaml.Controls;

namespace FishNTrips.Uwp.ViewModels
{
    /// <seealso cref="FishNTrips.Uwp.Helpers.Observable" />
    public class RegisterViewModel : Observable
    {

        /// <summary>
        /// The users data access
        /// </summary>
        private Users usersDataAccess = new Users();


        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterViewModel"/> class.
        /// </summary>
        public RegisterViewModel()
        {
        }

        /// <summary>
        /// The username
        /// </summary>
        public string username;
        /// <summary>
        /// The password
        /// </summary>
        public string password;


        /// <summary>
        /// Registers this instance.
        /// </summary>
        /// <returns></returns>
        public async Task Register() {

            if ((username == "" || username == null) && (password == "" || password == null))
            {
                ContentDialog missingUserAndPasswordDialog = new ContentDialog
                {
                    Title = "Input error",
                    Content = "Username and password is empty",
                    CloseButtonText = "OK"
                };
                await missingUserAndPasswordDialog.ShowAsync();
            }

            else if (username == "" || username == null)
            {
                ContentDialog missingUserDialog = new ContentDialog
                {
                    Title = "Input error",
                    Content = "Username is empty",
                    CloseButtonText = "OK"
                };
                await missingUserDialog.ShowAsync();
            }

            else if (password == "" || password == null)
            {
                ContentDialog missingPasswordDialog = new ContentDialog
                {
                    Title = "Input error",
                    Content = "Password is empty",
                    CloseButtonText = "OK"
                };
                await missingPasswordDialog.ShowAsync();
            }

            else if (await UsernameExists())
            {
                ContentDialog usernameExistsDialog = new ContentDialog
                {
                    Title = "Username allready registered",
                    Content = "Existing username, please choose another username",
                    CloseButtonText = "OK"
                };
                await usernameExistsDialog.ShowAsync();
            }

            else if (password.Length < 8) {
                ContentDialog passwordErrorDialog = new ContentDialog
                {
                    Title = "Password Error",
                    Content = "Password needs to be at least 8 characters long",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await passwordErrorDialog.ShowAsync();
            }

            else {
                User newUser = new User {
                    UserName = username,
                    UserPassword = password
                };

                if (await usersDataAccess.PostUserAsync(newUser)) {
                    ContentDialog userRegisteredDialog = new ContentDialog
                    {
                        Title = "Registered",
                        Content = "User is now registered",
                        CloseButtonText = "Ok"
                    };
                    ContentDialogResult result = await userRegisteredDialog.ShowAsync();

                    NavigationService.Navigate(typeof(LoginPage), newUser);
                }
                else {
                    ContentDialog userRegisteredErrorDialog = new ContentDialog
                    {
                        Title = "Error",
                        Content = "User registration error",
                        CloseButtonText = "Ok"
                    };
                    ContentDialogResult result = await userRegisteredErrorDialog.ShowAsync();
                }
            }
        }

        /// <summary>
        /// Usernames the exists.
        /// </summary>
        /// <returns></returns>
        public async Task<bool> UsernameExists()
        {
            User[] users = await usersDataAccess.GetUsersAsync();
            foreach (User u in users)
            {
                if (u.UserName == username)
                    return true;
            }
            return false;
        }
    }
}
