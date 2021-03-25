using System;
using System.Collections.Generic;
using System.Net.Http;
using GraphQl_Client.Library.Helpers;
using GraphQl_Client.Library.Model;
using Newtonsoft.Json;

namespace GraphQl_Client.Library.Client
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

        public List<Test> GetAllTests()
        {
            var result = _httpClient.GetAsync("tests").Result;
            var data = result.Content.ReadAsStringAsync();
            var tests = JsonConvert.DeserializeObject<List<Test>>(data.Result);
            return tests;
        }

        public Test GetTest(int testId)
        {
            var result = _httpClient.GetAsync($"tests/{testId}").Result;
            var data = result.Content.ReadAsStringAsync();
            var test = JsonConvert.DeserializeObject<Test>(data.Result);
            return test;
        }
    }
}
