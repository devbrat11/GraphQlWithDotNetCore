using System;
using System.Collections.Generic;
using System.Net.Http;
using GraphQl_Client.Library.Helpers;
using GraphQl_Client.Library.Model;

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

        public IEnumerable<Test> GetAllTests()
        {
            var response = _httpClient.GetAsync("tests").Result;
            return new List<Test>();
        }

        public Test GetTest(int testId)
        {
            throw new NotImplementedException();
        }
    }
}
