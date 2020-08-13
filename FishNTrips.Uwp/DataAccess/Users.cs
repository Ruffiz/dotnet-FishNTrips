using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using FishNTrips.Model;

namespace FishNTrips.Uwp.DataAccess
{
    class Users
    {
        /// <summary>
        /// The HTTP client
        /// </summary>
        readonly HttpClient _httpClient = new HttpClient();
        /// <summary>
        /// The users base URI
        /// </summary>
        static readonly Uri usersBaseUri = new Uri("http://localhost:56520/api/users");

        /// <summary>
        /// Gets the users asynchronous.
        /// </summary>
        /// <returns></returns>
        internal async Task<User[]> GetUsersAsync() {
            try
            {
                var result = await _httpClient.GetAsync(usersBaseUri);
                string json = await result.Content.ReadAsStringAsync();
                User[] users = JsonConvert.DeserializeObject<User[]>(json);

                return users;
            }
            catch(HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }

        /// <summary>
        /// Gets the user asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        internal async Task<User> GetUserAsync(int id)
        {
            try
            {
                var result = await _httpClient.GetAsync(usersBaseUri + $"/{id}");
                string json = await result.Content.ReadAsStringAsync();
                User user = JsonConvert.DeserializeObject<User>(json);

                return user;
            }
            catch (HttpRequestException ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }

        /// <summary>
        /// Posts the user asynchronous.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        internal async Task<bool> PostUserAsync(User user)
        {
            try
            {
                var stringContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(usersBaseUri, stringContent);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }


        }

        /// <summary>
        /// Updates the user asynchronous.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        public async Task<bool> UpdateUserAsync(User user)
        {
            try
            {
                var stringContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync(new Uri(usersBaseUri, "users/" + user.UserId), stringContent);
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Deletes the user asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        internal async Task<bool> DeleteUserAsync(int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync(new Uri(usersBaseUri, "users/" + id));
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        
    }
}
