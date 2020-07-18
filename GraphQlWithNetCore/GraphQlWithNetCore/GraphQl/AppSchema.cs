using GraphQL;

namespace GraphQlWithNetCore.GraphQl
{
    public class AppSchema:GraphQL.Types.Schema
    {
        public AppSchema(IDependencyResolver resolver):base(resolver)
        {
            Query = resolver.Resolve<TestQuery>();
            Mutation = resolver.Resolve<TestMutation>();
        }
    }
}
