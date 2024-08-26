using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;
using Troque.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Troque.Api
{
    public class ExchangeResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public Exchange Data { get; set; }
    }

    public class ListExchangeResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public List<Exchange> Data { get; set; }
    }
    public class ExchangeApi
    {
        private static readonly HttpClient client = new HttpClient();

        public ExchangeApi()
        {

        }

        public async Task<Exchange> Exchangeproduit(string deliveryadress,List<int> ownerproduct,List<int> takerproduct,int ownerid,int takerid)
        {
            var productData = new
            {
                delivery_address = deliveryadress,
                owner_products = ownerproduct.ToArray(),
                taker_products = takerproduct.ToArray(),
                owner_id = ownerid,
                taker_id = takerid
            };

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(productData);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            string contentString = await data.ReadAsStringAsync();
            try
            {
                string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
                string accessToken = AuthTokenManager.AccessToken;
                if (string.IsNullOrEmpty(accessToken))
                {
                    throw new InvalidOperationException("Access token is missing.");
                }
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("x-auth-token", accessToken);
                HttpResponseMessage response = await client.PostAsync(baseUrl + "/exchanges", data);
                string responseContent = await response.Content.ReadAsStringAsync();

                response.EnsureSuccessStatusCode();
                var products = Newtonsoft.Json.JsonConvert.DeserializeObject<ExchangeResponse>(responseContent);
                return products.Data;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public async Task<List<Exchange>> GetMyExchange()
        {
            try
            {
                string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
                string accessToken = AuthTokenManager.AccessToken;
                if (string.IsNullOrEmpty(accessToken))
                {
                    throw new InvalidOperationException("Access token is missing.");
                }
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("x-auth-token", accessToken);
                HttpResponseMessage response = await client.GetAsync(baseUrl + "/exchanges");
                string responseContent = await response.Content.ReadAsStringAsync();

                response.EnsureSuccessStatusCode();
                var products = Newtonsoft.Json.JsonConvert.DeserializeObject<ListExchangeResponse>(responseContent);
                return products.Data;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        //accepter exchange
        public async Task<bool> AcceptExchange(int id)
        {
            try
            {
                string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
                string accessToken = AuthTokenManager.AccessToken;
                if (string.IsNullOrEmpty(accessToken))
                {
                    throw new InvalidOperationException("Access token is missing.");
                }
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("x-auth-token", accessToken);
                HttpResponseMessage response = await client.PostAsync(baseUrl + "/exchanges/" + id + "/accept", null);
                string responseContent = await response.Content.ReadAsStringAsync();

                response.EnsureSuccessStatusCode();
                MessageBox.Show("Echange accepté avec succès");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        // recevoir exchange
        public async Task<bool> ReceiveExchange(int id)
        {
            try
            {

                var (latitude, longitude) = (10.5,10.4);
                double[] loaclisation = await GetLocationAsync();
                if (loaclisation != null)
                {
                    latitude = loaclisation[0];
                    longitude = loaclisation[1];
                }
                
                // Set up the request body with location data
                var locationData = new
                {
                    accept = true,
                    longitude= longitude,
                    latitude= latitude
                };
                var json = JsonConvert.SerializeObject(locationData);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
                string accessToken = AuthTokenManager.AccessToken;
                if (string.IsNullOrEmpty(accessToken))
                {
                    throw new InvalidOperationException("Access token is missing.");
                }
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("x-auth-token", accessToken);
                HttpResponseMessage response = await client.PutAsync(baseUrl + "/exchanges/" + id + "/receive", data);
                string responseContent = await response.Content.ReadAsStringAsync();
                response.EnsureSuccessStatusCode();
                MessageBox.Show("Echange reçu avec succès");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private async Task<double[]> GetLocationAsync()
        {
            string apiKey = "89ee3efff1ac6313079855a7e7e79880";  // Replace with your actual API key
            string url = $"http://api.ipstack.com/check?access_key={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Make an asynchronous request to the API
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    // Read the response as a string
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Parse the JSON response
                    var json = JObject.Parse(responseBody);

                    // Extract latitude and longitude
                    double latitude = (double)json["latitude"];
                    double longitude = (double)json["longitude"];
                    double[] localisationtions = new double[2];
                    localisationtions[0] = latitude;
                    localisationtions[1] = longitude;
                    //MessageBox.Show($"Latitude: {latitude}, Longitude: {longitude}");
                    return localisationtions;
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show("Request error: " + e.Message);
                    return null;
                }
            }
        }

    }
}
