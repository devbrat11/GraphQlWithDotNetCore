using GraphQl.Service.Entities;
using GraphQL.Types;
using GraphQlService.Data;

namespace GraphQl.Service.GraphQl.UserService.Types
{
    /// <summary>
    /// Wrapper Output Model class for the User entity
    /// </summary>
    public class UserType : ObjectGraphType<User>
    {
        public UserType(IUserRepository repository)
        {
            Name = "user";
            Field(x => x.PK, type: typeof(IdGraphType));
            Field(x => x.Name);
            Field(x => x.DateOfBirth);
            Field(x => x.UserID);
        }
    }
}
