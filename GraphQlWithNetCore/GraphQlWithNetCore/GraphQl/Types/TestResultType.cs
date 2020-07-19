using GraphQL.Types;
using GraphQlWithNetCore.Data;

namespace GraphQlWithNetCore.GraphQl.Types
{
    /// <summary>
    /// Wrapper Output Model class for the TestResult entity
    /// </summary>
    public class TestResultType : ObjectGraphType<TestResult>
    {
        public TestResultType()
        {
            Field(x => x.ResultId);
            Field(x => x.TestId);
            Field<VerdictEnumType>("Verdict", "Result Verdict");
        }
    }

   
}
