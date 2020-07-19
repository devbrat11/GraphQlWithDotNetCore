using GraphQL.Types;
using GraphQlWithNetCore.Enums;

namespace GraphQlWithNetCore.GraphQl.Types
{
    /// <summary>
    /// Wrapper GraphQl type for Verdict enum type
    /// </summary>
    public class VerdictEnumType : EnumerationGraphType<Verdict>
    {
        public VerdictEnumType()
        {
            Name = "Verdict";
            Description = "Result Verdict";
        }
    }
}
