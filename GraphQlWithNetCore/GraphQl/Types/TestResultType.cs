using GraphQL.Types;
using GraphQlUsingAspCoreDotNet.Data;

namespace GraphQlUsingAspCoreDotNet.GraphQl.Types
{
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
