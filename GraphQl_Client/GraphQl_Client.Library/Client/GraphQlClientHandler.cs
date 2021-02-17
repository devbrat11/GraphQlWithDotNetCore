using System;
using System.Collections.Generic;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQL;
using GraphQl_Client.Library.Helpers;
using GraphQl_Client.Library.Model;

namespace GraphQl_Client.Library.Client
{
    public class GraphQlClientHandler : IClientHandler
    {
        private GraphQLHttpClient _client;

        public GraphQlClientHandler()
        {
            _client = new GraphQLHttpClient(new GraphQLHttpClientOptions
            {
                EndPoint = new Uri(Backend.GraphQlEndPoint)
            }, new NewtonsoftJsonSerializer());
        }

        public IEnumerable<Test> GetAllTests()
        {
            var request = new GraphQLRequest()
            {
                Query = QueryBuilder.GetAllTestsQuery(),
            };
            var response = _client.SendQueryAsync<IEnumerable<Test>>(request).Result;

            return new List<Test>();
        }

        public Test GetTest(int testId)
        {
            throw new NotImplementedException();
        }
    }
}
