using System;
using System.Collections.Generic;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQL;
using GraphQlClient.Library.Helpers;
using GraphQlClient.Library.Model;
using Newtonsoft.Json;
using GraphQl.Client.Library.Model;

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

        public List<User> GetAllUsers()
        {
            var request = new GraphQLRequest()
            {
                Query = QueryBuilder.GetAllUsersQuery(),
            };

            var result = GetUsers(request);
            return result.Users;
        }

        public User GetUser(string emailID)
        {
            var request = new GraphQLRequest()
            {
                Query = QueryBuilder.GetUserWithID(emailID),
            };

            var result = GetUsers(request);
            return result.Users[0];
        }

        private UserData GetUsers(GraphQLRequest request)
        {
            var response = _client.SendQueryAsync<object>(request);
            var result = JsonConvert.DeserializeObject<UserData>(response.Result.Data.ToString());
            return result;
        }
    }
}
