using System;
using System.Collections.Generic;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQL;
using GraphQlClient.Library.Helpers;
using GraphQlClient.Library.Model;
using Newtonsoft.Json;

namespace GraphQlClient.Library.Client
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

        public List<Test> GetAllTests()
        {
            var request = new GraphQLRequest()
            {
                Query = QueryBuilder.GetAllTestsQuery(),
            };

            var response = _client.SendQueryAsync<object>(request);
            var result = JsonConvert.DeserializeObject<TestData>(response.Result.Data.ToString());

            return result.Tests ;
        }

        public Test GetTest(int testId)
        {
            var request = new GraphQLRequest()
            {
                Query = QueryBuilder.GetTestForIdQuery(testId),
            };

            var response = _client.SendQueryAsync<object>(request);
            var result = JsonConvert.DeserializeObject<TestData>(response.Result.Data.ToString());

            return result.Tests[0];
        }
    }
}
