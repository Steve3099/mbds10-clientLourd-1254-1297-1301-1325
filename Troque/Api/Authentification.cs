﻿using Newtonsoft.Json;
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
    public class LoginResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public LoginData Data { get; set; }
    }

    public class LoginData
    {
        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }

    public class Authentification
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task<User> Login(string email, string password)
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
                client.DefaultRequestHeaders.Clear();
                string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
                HttpResponseMessage response = await client.PostAsync(baseUrl+ "/auth/login", data);
                response.EnsureSuccessStatusCode();

                // Optionally, handle the response content here (e.g., JWT token, user data)
                var responseContent = await response.Content.ReadAsStringAsync();
                
                var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(responseContent);
                string accessToken = loginResponse.Data.AccessToken;
                AuthTokenManager.AccessToken = loginResponse.Data.AccessToken;
                Console.WriteLine(AuthTokenManager.AccessToken);
                User user = loginResponse.Data.User;
                AuthTokenManager.id = user.Id;
                return user;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request error: {ex.Message}");
                return null;
            }
        }

        //inscription
        public async Task<bool> Inscription(string username, string email, string password, string address)
        {
            var inscriptionData = new
            {
                username = username,
                email = email,
                password = password,
                address = address,
                role = "USER"
            };

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(inscriptionData);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                client.DefaultRequestHeaders.Clear();
                string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
                HttpResponseMessage response = await client.PostAsync(baseUrl + "/auth/register", data);
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
