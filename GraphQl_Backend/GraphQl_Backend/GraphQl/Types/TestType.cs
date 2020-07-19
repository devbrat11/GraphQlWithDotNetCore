using GraphQl_Backend.Data;
using GraphQL.Types;

namespace GraphQl_Backend.GraphQl.Types
{
    /// <summary>
    /// Wrapper Output Model class for the Test entity
    /// </summary>
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
}
