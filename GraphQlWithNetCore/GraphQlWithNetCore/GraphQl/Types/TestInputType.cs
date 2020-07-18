using GraphQL.Types;

namespace GraphQlWithNetCore.GraphQl.Types
{
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
