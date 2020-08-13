using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using FishNTrips.Model;
using System.Threading.Tasks;

namespace FishNTrips.Uwp.DataAccess
{
    class Locations
    {
        /// <summary>
        /// The HTTP client
        /// </summary>
        readonly HttpClient _httpClient = new HttpClient();
        /// <summary>
        /// The locations base URI
        /// </summary>
        static readonly Uri locationsBaseUri = new Uri("http://localhost:56520/api/locations");

        /// <summary>
        /// Gets the locations asynchronous.
        /// </summary>
        /// <returns></returns>
        internal async Task<Location[]> GetLocationsAsync() {
            try
            {
                var result = await _httpClient.GetAsync(locationsBaseUri);
                string json = await result.Content.ReadAsStringAsync();
                Location[] locations = JsonConvert.DeserializeObject<Location[]>(json);

                return locations;
            }
            catch (HttpRequestException ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Gets the location asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        internal async Task<Location> GetLocationAsync(int id)
        {
            try
            {
                var result = await _httpClient.GetAsync(locationsBaseUri + $"/{id}");
                string json = await result.Content.ReadAsStringAsync();
                Location location = JsonConvert.DeserializeObject<Location>(json);

                return location;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Posts the location asynchronous.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <returns></returns>
        internal async Task<bool> PostLocationAsync(Location location)
        {
            try
            {
                var stringContent = new StringContent(JsonConvert.SerializeObject(location), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(locationsBaseUri, stringContent);
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

        /*internal async Task<HttpResponseMessage> PutLocationAsync(int id) {
            return await _httpClient.PutAsync(new Uri())
        }*/

        /// <summary>
        /// Deletes the location asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        internal async Task<HttpResponseMessage> DeleteLocationAsync(int id)
        {
            try
            {
                return await _httpClient.DeleteAsync(new Uri(locationsBaseUri, "locations/" + id));
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

    }
}
