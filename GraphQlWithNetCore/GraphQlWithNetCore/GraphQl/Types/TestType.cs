using GraphQlWithNetCore.Data;
using GraphQL.Types;

namespace GraphQlWithNetCore.GraphQl.Types
{
    public class TestType:ObjectGraphType<Test>
    {
        public TestType(IRepository repository)
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Description);
            Field(x => x.Tester);
            Field<ListGraphType<TestResultType>>(
                "Results",
                resolve:context=>repository.GetTestResults(context.Source.Id));
        }
       
    }

    public class TestInputType : InputObjectGraphType
    {
        public TestInputType()
        {
            Name = "testInput";
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("tester");
            Field<StringGraphType>("Description");
        }
    }
}
