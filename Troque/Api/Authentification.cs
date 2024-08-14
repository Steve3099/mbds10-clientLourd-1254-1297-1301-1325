using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Troque.Api
{
    public class Authentification
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task<bool> Login(string email, string password)
        {
            Console.Write(email);
            Console.WriteLine(password);
            var loginData = new
            {
                email = email,
                password = password
            };

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(loginData);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
                HttpResponseMessage response = await client.PostAsync(baseUrl+ "/auth/login", data);
                response.EnsureSuccessStatusCode();

                // Optionally, handle the response content here (e.g., JWT token, user data)
                var responseContent = await response.Content.ReadAsStringAsync();
                return true;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request error: {ex.Message}");
                return false;
            }
        }
    }
}
