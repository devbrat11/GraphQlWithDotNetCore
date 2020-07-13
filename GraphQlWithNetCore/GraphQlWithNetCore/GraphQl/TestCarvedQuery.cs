using GraphQL.Types;
using GraphQlWithNetCore.Data;
using GraphQlWithNetCore.GraphQl.Types;

namespace GraphQlWithNetCore.GraphQl
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
