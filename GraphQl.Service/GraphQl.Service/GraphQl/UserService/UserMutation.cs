using GraphQl.Service.GraphQl.UserService.Types;
using GraphQl.Service.Model;
using GraphQL.Types;
using GraphQlService.Data;
using GraphQlService.GraphQl.UserService.Messaging;
using GraphQlService.GraphQl.UserService.Types;

namespace GraphQlService.GraphQl.UserService
{
    /// <summary>
    /// Mutation Defintion Class
    /// </summary>
    public class UserMutation : ObjectGraphType
    {
        public UserMutation(IUserRepository repository,UserMessagingService messagingService)
        {
            Field<UserType>(
                "addUser",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<UserRegistrationType>>() { Name = "user" }),

                resolve: context =>
                {
                    var user = context.GetArgument<UserRegistrationInfo>("user");
                    var isUserAdded = repository.AddUser(user);
                    if (isUserAdded)
                    {
                        messagingService.AddUserAddedMessage(user);
                        return repository.GetUser(user.EmailID);
                    }
                    else
                    {
                        context.Errors.Add(new GraphQL.ExecutionError("User cannot be added."));
                        return null;
                    }
                }
                );

        }
    }
}
