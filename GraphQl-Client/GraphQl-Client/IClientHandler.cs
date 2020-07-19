using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using GraphQL.Client.Http;
using GraphQl_Client.Model;
using Newtonsoft.Json;
using GraphQL.Client.Abstractions.Websocket;
using GraphQL;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Net;

namespace GraphQl_Client
{
    public interface IClientHandler
    {
        IEnumerable<Test> GetAllTests();
        Test GetTest(int testId);
    }

    public class Backend
    {
        public static string GraphQlEndPoint { get; } = @"https://localhost:44388/graphql/";
    }

    public class QueryBuilder
    {
        public static string GetAllTestsQuery()
        {
            var query = @"{tests{id name}}";
            return query;
        }
    }
}
