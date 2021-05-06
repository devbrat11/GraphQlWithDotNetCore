using GraphQl.Service.GraphQl.UserService.Types;
using GraphQL.Types;
using GraphQlService.Data;

namespace GraphQlService.GraphQl.UserService
{
    /// <summary>
    /// Query Definition Class
    /// </summary>
    public class UserQuery : ObjectGraphType
    {
        public UserQuery(IUserRepository repository)
        {
            Field<ListGraphType<UserType>>(
                "users",
                resolve: context =>
                {
                    return repository.GetAllUsers();
                }
                );

            Field<UserType>(
               "user",
               arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "userID" }),
               resolve: context =>
               {
                   var userID = context.GetArgument<string>("userID");
                   var user = repository.GetUser(userID);
                   if (user == null)
                   {
                       //logging error
                       context.Errors.Add(new GraphQL.ExecutionError("User does not exist!"));
                       return null;
                   }
                   return user;
               }

               );

        }
    }
}
