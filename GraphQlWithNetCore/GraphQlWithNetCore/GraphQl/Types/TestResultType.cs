using GraphQL.Types;
using GraphQlWithNetCore.Data;

namespace GraphQlWithNetCore.GraphQl.Types
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

    public class TestResultInputType : InputObjectGraphType
    {
        public TestResultInputType()
        {
            Name = "testResultInput";
            Field<NonNullGraphType<StringGraphType>>("resultId");
            Field<IntGraphType>("testId");
            Field<VerdictEnumType>("verdict");
        }
    }
}
