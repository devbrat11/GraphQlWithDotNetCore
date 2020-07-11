using GraphQL.Types;
using GraphQlUsingAspCoreDotNet.Enums;

namespace GraphQlUsingAspCoreDotNet.GraphQl.Types
{
    public class VerdictEnumType : EnumerationGraphType<Verdict>
    {
        public VerdictEnumType()
        {
            Name = "Verdict";
            Description = "Result Verdict";
        }
    }
}
