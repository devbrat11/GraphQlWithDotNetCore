using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQlWithNetCore.Data;
using GraphQlWithNetCore.GraphQl.Types;

namespace GraphQlWithNetCore.GraphQl
{
    public class TestCarvedMutation : ObjectGraphType
    {
        public TestCarvedMutation(IRepository repository)
        {
            Field<TestType>(
                "createTest",
                arguments: new QueryArguments(new QueryArgument<TestInputType>() { Name = "test" }),

                resolve: context =>
                {
                    var test = context.GetArgument<Test>("test");
                    return repository.CreateTest(test);
                }
                );

            Field<TestType>(
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
