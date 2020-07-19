using GraphQL.Types;

namespace GraphQl_Backend.GraphQl.Types
{
    /// <summary>
    /// Wrapper Input Model class for the TestResult entity
    /// </summary>
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
