using System.Collections.Generic;
using GraphQL.Types;
using GraphQlWithNetCore.Data;

namespace GraphQlWithNetCore.GraphQl.Messaging
{
    /// <summary>
    /// Wrapper Subscription Model class for the Test entity
    /// </summary>
    public class TestAddedMessage:ObjectGraphType<Test>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tester { get; set; }
    }
}
