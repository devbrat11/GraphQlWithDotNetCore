using GraphQlUsingAspCoreDotNet.Data;
using GraphQL.Types;
using GraphQlUsingAspCoreDotNet.GraphQl.Types;

namespace GraphQlUsingAspCoreDotNet.GraphQl
{
    public class TestCarvedQuery:ObjectGraphType
    {
        public TestCarvedQuery(IRepository repository)
        {
            Field<ListGraphType<TestType>>(
                "Tests",
                resolve: context=>repository.GetAllTests()
                );

            Field<TestType>(
               "Test",
               arguments: new QueryArguments(
                new QueryArgument<IntGraphType> { Name = "id" }),
               resolve: context => 
               {
                   var id = context.GetArgument<int>("id");
                   return repository.GetTest(id);
               }

               );
        }
    }
}
