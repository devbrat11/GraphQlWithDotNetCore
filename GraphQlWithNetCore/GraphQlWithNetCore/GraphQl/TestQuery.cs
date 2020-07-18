using GraphQL.Types;
using GraphQlWithNetCore.Data;
using GraphQlWithNetCore.GraphQl.Types;

namespace GraphQlWithNetCore.GraphQl
{
    public class TestQuery : ObjectGraphType
    {
        public TestQuery(IRepository repository)
        {
            Field<ListGraphType<TestType>>(
                "tests",
                resolve: context =>
                {
                    return repository.GetAllTests();
                }
                );

            Field<TestType>(
               "test",
               arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" }),
               resolve: context =>
               {
                   var id = context.GetArgument<int>("id");
                   return repository.GetTest(id);
               }

               );

            Field<ListGraphType<TestResultType>>(
                "testResults",
                resolve: context =>
                {
                    return repository.GetAllTestResults();
                }
                );
        }
    }
}
