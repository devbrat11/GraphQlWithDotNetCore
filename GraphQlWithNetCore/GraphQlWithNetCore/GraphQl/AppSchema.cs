using GraphQL;

namespace GraphQlWithNetCore.GraphQl
{
    /// <summary>
    /// Schema Definition Class
    /// </summary>
    public class AppSchema:GraphQL.Types.Schema
    {
        public AppSchema(IDependencyResolver resolver):base(resolver)
        {
            Query = resolver.Resolve<TestQuery>();
            Mutation = resolver.Resolve<TestMutation>();
            Subscription = resolver.Resolve<TestSubscription>();
        }
    }
}
