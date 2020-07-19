using GraphQL.Types;
using GraphQl_Backend.Data;
using GraphQl_Backend.GraphQl.Types;

namespace GraphQl_Backend.GraphQl
{
    /// <summary>
    /// Query Definition Class
    /// </summary>
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
                   var test = repository.GetTest(id);
                   if (test == null)
                   {
                       //logging error
                       context.Errors.Add(new GraphQL.ExecutionError("Test does not exist!"));
                       return null;
                   }
                   return test;
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
