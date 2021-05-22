using System;
using System.Collections.Generic;
using System.Net.Http;
using GraphQlClient.Library.Helpers;
using GraphQlClient.Library.Model;
using Newtonsoft.Json;

namespace GraphQlClient.Library.Client
{
    public class HttpBasedClientHandler : IClientHandler
    {
        private HttpClient _httpClient;

        public HttpBasedClientHandler()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri(Backend.RestEndPoint)
            };
        }

        public List<User> GetAllUsers()
        {
            var result = _httpClient.GetAsync("users").Result;
            var data = result.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<List<User>>(data.Result);
            return users;
        }

        public User GetUser(string emailID)
        {
            var result = _httpClient.GetAsync($"users/{emailID}").Result;
            var data = result.Content.ReadAsStringAsync();
            var test = JsonConvert.DeserializeObject<User>(data.Result);
            return test;
        }
    }
}
