using GraphQL.Resolvers;
using GraphQL.Types;
using GraphQlWithNetCore.GraphQl.Messaging;

namespace GraphQlWithNetCore.GraphQl
{
    /// <summary>
    /// Subscription Definition Class
    /// </summary>
    public class TestSubscription : ObjectGraphType
    {
        public TestSubscription(TestUpdatesMessagingService messagingService)
        {
            Name = "Subscription";
            AddField(new EventStreamFieldType()
            {
                Name = "testAdded",
                Type = typeof(TestAddedMessage),
                Resolver = new FuncFieldResolver<TestAddedMessage>(c => c.Source as TestAddedMessage),
                Subscriber = new EventStreamResolver<TestAddedMessage>(c => messagingService.GetMessages())
            });
        }
    }
}
