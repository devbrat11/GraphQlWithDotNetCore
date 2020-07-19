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
                BaseAddress = new Uri(Backend.RestEndPoint)
            };
        }

        public IEnumerable<Test> GetAllTests()
        {
            throw new NotImplementedException();
        }

        public Test GetTest(int testId)
        {
            throw new NotImplementedException();
        }
    }
}
