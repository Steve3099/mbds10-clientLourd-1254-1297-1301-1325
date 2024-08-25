using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Troque.Model;

namespace Troque.Api
{
    public class ProductResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public List<Product> Data { get; set; }
    }

    public class ProductInsertResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public Product Data { get; set; }
    }
    public class ProductApi
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<Product> AddProduct(string product_name, string description, List<int> categ)
        {
            var productData = new
            {
                product_name = product_name,
                description = description,
                categories = categ.ToArray()
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
                HttpResponseMessage response = await client.PostAsync(baseUrl + "/products", data);
                string responseContent = await response.Content.ReadAsStringAsync();
                var product = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductInsertResponse>(responseContent);

                response.EnsureSuccessStatusCode();
                return product.Data;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public async Task<Product> GetOneProduct(int id)
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
                HttpResponseMessage response = await client.GetAsync(baseUrl + "/products/" + id);
                response.EnsureSuccessStatusCode();
                var responseContent = await response.Content.ReadAsStringAsync();
                var product = Newtonsoft.Json.JsonConvert.DeserializeObject<Product>(responseContent);
                return product;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public async Task<List<Product>> GetProducts()
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
                HttpResponseMessage response = await client.GetAsync(baseUrl + "/products");
                response.EnsureSuccessStatusCode();
                var responseContent = await response.Content.ReadAsStringAsync();
                var products = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(responseContent);
                return products;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public async Task<List<Product>> GetProductsUser(int id)
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
                HttpResponseMessage response = await client.GetAsync(baseUrl + "/products?userId=" + id);
                response.EnsureSuccessStatusCode();
                var responseContent = await response.Content.ReadAsStringAsync();
                var products = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductResponse>(responseContent);
                return products.Data;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public async Task<List<Product>> GetAllProductsUser()
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
                HttpResponseMessage response = await client.GetAsync(baseUrl + "/products");
                response.EnsureSuccessStatusCode();
                var responseContent = await response.Content.ReadAsStringAsync();
                var products = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductResponse>(responseContent);
                return products.Data;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        //upload image us id and image
        public async Task<bool> UploadImage(int id, Image image)
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
                MultipartFormDataContent form = new MultipartFormDataContent();
                ImageConverter converter = new ImageConverter();
                byte[] imageBytes = (byte[])converter.ConvertTo(image, typeof(byte[]));
                form.Add(new ByteArrayContent(imageBytes, 0, imageBytes.Length), "file", "image.jpg");
                HttpResponseMessage response = await client.PostAsync(baseUrl + "/products/uploadImage/" + id, form);
                response.EnsureSuccessStatusCode();
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
