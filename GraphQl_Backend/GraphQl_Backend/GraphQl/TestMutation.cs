using GraphQL.Types;
using GraphQl_Backend.Data;
using GraphQl_Backend.GraphQl.Messaging;
using GraphQl_Backend.GraphQl.Types;

namespace GraphQl_Backend.GraphQl
{
    /// <summary>
    /// Mutation Defintion Class
    /// </summary>
    public class TestMutation : ObjectGraphType
    {
        public TestMutation(IRepository repository,TestUpdatesMessagingService messagingService)
        {
            Field<TestType>(
                "createTest",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<TestInputType>>() { Name = "test" }),

                resolve: context =>
                {
                    var test = context.GetArgument<Test>("test");
                    repository.CreateTest(test);
                    messagingService.AddTestAddedMessage(test);
                    return test;
                }
                );

            Field<BooleanGraphType>(
              "updateTest",
              arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>>(){Name="id"}, new QueryArgument<TestInputType>() { Name = "test" }),

               resolve: context =>
               {
                   var id = context.GetArgument<int>("id");
                   var updatedTest = context.GetArgument<Test>("test");
                   var isUpdated = repository.UpdateTest(id,updatedTest);
                   return isUpdated;
               }
               );

            Field<BooleanGraphType>(
            "deleteTest",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>>() { Name = "id" }),

             resolve: context =>
             {
                 var id = context.GetArgument<int>("id");
                 var isDeleted = repository.DeleteTest(id);
                 return isDeleted;
             }
             );

            Field<TestResultType>(
              "addTestResult",
              arguments: new QueryArguments(new QueryArgument<TestResultInputType>() { Name = "testResult" }),

               resolve: context =>
               {
                   var testResult = context.GetArgument<TestResult>("testResult");
                   repository.AddTestResult(testResult);
                   return testResult;
               }
               );
        }
    }
}
