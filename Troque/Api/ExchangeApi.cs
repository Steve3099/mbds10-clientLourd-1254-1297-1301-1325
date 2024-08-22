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
            Console.WriteLine(contentString);
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
    }
}
