using GraphQL;

namespace GraphQlUsingAspCoreDotNet.GraphQl
{
    public class TestCarvedSchema:GraphQL.Types.Schema
    {
        public TestCarvedSchema(IDependencyResolver resolver):base(resolver)
        {
            Query = resolver.Resolve<TestCarvedQuery>();
        }
    }
}
