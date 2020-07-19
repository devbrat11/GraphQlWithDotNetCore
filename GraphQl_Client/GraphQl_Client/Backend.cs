using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQl_Client
{
    public class Backend
    {
        public static string GraphQlEndPoint { get; } = @"https://localhost:44388/graphql";
        public static string RestEndPoint { get; } = @"http://localhost:44354/api";
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
