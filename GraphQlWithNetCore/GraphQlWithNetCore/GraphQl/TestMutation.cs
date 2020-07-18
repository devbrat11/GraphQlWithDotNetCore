using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQlWithNetCore.Data;
using GraphQlWithNetCore.GraphQl.Types;

namespace GraphQlWithNetCore.GraphQl
{
    public class TestMutation : ObjectGraphType
    {
        public TestMutation(IRepository repository)
        {
            Field<TestType>(
                "createTest",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<TestInputType>>() { Name = "test" }),

                resolve: context =>
                {
                    var test = context.GetArgument<Test>("test");
                    return repository.CreateTest(test);
                }
                );

            Field<BooleanGraphType>(
              "updateTest",
              arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>>(){Name="id"}, new QueryArgument<TestInputType>() { Name = "test" }),

               resolve: context =>
               {
                   var id = context.GetArgument<int>("id");
                   var updatedTest = context.GetArgument<Test>("test");
                   return repository.UpdateTest(id,updatedTest);
               }
               );

            Field<BooleanGraphType>(
            "deleteTest",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>>() { Name = "id" }),

             resolve: context =>
             {
                 var id = context.GetArgument<int>("id");
                 return repository.DeleteTest(id);
             }
             );

            Field<TestResultType>(
              "addTestResult",
              arguments: new QueryArguments(new QueryArgument<TestResultInputType>() { Name = "testResult" }),

               resolve: context =>
               {
                   var testResult = context.GetArgument<TestResult>("testResult");
                   return repository.AddTestResult(testResult);
               }
               );
        }
    }
}
