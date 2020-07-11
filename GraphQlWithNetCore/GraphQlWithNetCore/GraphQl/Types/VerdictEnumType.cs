using GraphQL.Types;
using GraphQlWithNetCore.Enums;

namespace GraphQlWithNetCore.GraphQl.Types
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
