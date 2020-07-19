using GraphQL.Types;
using GraphQl_Backend.Enums;

namespace GraphQl_Backend.GraphQl.Types
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
