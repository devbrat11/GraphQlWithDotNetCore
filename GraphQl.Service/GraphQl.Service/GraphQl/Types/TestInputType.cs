using GraphQL.Types;

namespace GraphQlService.GraphQl.Types
{
    /// <summary>
    /// Wrapper Input Model class for the Test entity
    /// </summary>
    public class TestInputType : InputObjectGraphType
    {
        public TestInputType()
        {
            Name = "testInput";
            Field<NonNullGraphType<IntGraphType>>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("tester");
            Field<StringGraphType>("description");
        }
    }
}
