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

namespace Troque.Api
{
    public class RatingApi
    {
        private static readonly HttpClient client = new HttpClient();
        public RatingApi() { }
        public async Task<bool> sendRating(int userId,string review,double rating)
        {
            var productData = new
            {
                concerned_user_id = userId,
                review = review,
                rating = rating
            };

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(productData);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            Console.WriteLine(data.ReadAsStringAsync().ToString());
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
                HttpResponseMessage response = await client.PostAsync(baseUrl + "/users/rate", data);
                string responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseContent);
                response.EnsureSuccessStatusCode();
                Console.WriteLine(responseContent);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
