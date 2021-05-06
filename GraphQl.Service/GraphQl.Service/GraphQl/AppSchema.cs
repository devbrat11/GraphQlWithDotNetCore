using GraphQL;
using GraphQlService.GraphQl.UserService;

namespace GraphQlService.GraphQl
{
    /// <summary>
    /// Schema Definition Class
    /// </summary>
    public class AppSchema:GraphQL.Types.Schema
    {
        public AppSchema(IDependencyResolver resolver):base(resolver)
        {
            Query = resolver.Resolve<UserQuery>();
            Mutation = resolver.Resolve<UserMutation>();
            Subscription = resolver.Resolve<UserSubscription>();
        }
    }
}
