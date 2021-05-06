using GraphQL.Resolvers;
using GraphQL.Types;
using GraphQlService.GraphQl.UserService.Messaging;

namespace GraphQlService.GraphQl.UserService
{
    /// <summary>
    /// Subscription Definition Class
    /// </summary>
    public class UserSubscription : ObjectGraphType
    {
        public UserSubscription(UserMessagingService messagingService)
        {
            Name = "Subscription";
            AddField(new EventStreamFieldType()
            {
                Name = "userAdded",
                Type = typeof(UserAddedMessage),
                Resolver = new FuncFieldResolver<UserAddedMessage>(c => c.Source as UserAddedMessage),
                Subscriber = new EventStreamResolver<UserAddedMessage>(c => messagingService.GetMessages())
            });
        }
    }
}
