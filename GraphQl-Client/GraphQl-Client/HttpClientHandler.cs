using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using GraphQl_Client.Model;
using Newtonsoft.Json;

namespace GraphQl_Client
{
    public class HttpClientHandler : IClientHandler
    {
        private HttpClient _httpClient;

        public HttpClientHandler()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri(Backend.GraphQlEndPoint)
            };
        }

        public IEnumerable<Test> GetAllTests()
        {
            var query = @"?query={tests{id name}}";
            var response = _httpClient.GetAsync(query).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            var tests = JsonConvert.DeserializeObject<List<Test>>(result);
            return tests;
        }

        public Test GetTest(int testId)
        {
            throw new NotImplementedException();
        }
    }
}
