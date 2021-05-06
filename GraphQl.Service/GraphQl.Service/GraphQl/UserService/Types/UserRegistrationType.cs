using GraphQl.Service.Model;
using GraphQL.Types;

namespace GraphQlService.GraphQl.UserService.Types
{
    /// <summary>
    /// Wrapper Input Model class for the User entity
    /// </summary>
    public class UserRegistrationType : InputObjectGraphType<UserRegistrationInfo>
    {
        public UserRegistrationType()
        {
            Name = "userRegistrationInfo";
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<DateTimeGraphType>("dateOfBirth");
            Field<NonNullGraphType<StringGraphType>>("userID");
            Field<StringGraphType>("password");
        }
    }
}
