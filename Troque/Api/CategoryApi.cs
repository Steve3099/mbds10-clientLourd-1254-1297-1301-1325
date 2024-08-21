using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Troque.Model;

namespace Troque.Api
{

    public class CategoryResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public List<Category> Data { get; set; }
    }
    public class CategoryApi
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<List<Category>> GetCategories()
        {
            try
            {
                string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];

                string accessToken = AuthTokenManager.AccessToken;
                if (string.IsNullOrEmpty(accessToken))
                {
                    throw new InvalidOperationException("Access token is missing.");
                }
                // Add the Authorization header with the Bearer token
                //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("x-auth-token", accessToken);
                //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("x-auth-token", accessToken);
               
                HttpResponseMessage response = await client.GetAsync(baseUrl + "/categories");
                response.EnsureSuccessStatusCode();

                // Optionally, handle the response content here (e.g., JWT token, user data)
                var responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseContent);
                var categoryResponse = JsonConvert.DeserializeObject<CategoryResponse>(responseContent);
                //User user = loginResponse.Data.category;
                
                return categoryResponse.Data;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request error: {ex.Message}");
                return null;
            }
        }
    }
}
