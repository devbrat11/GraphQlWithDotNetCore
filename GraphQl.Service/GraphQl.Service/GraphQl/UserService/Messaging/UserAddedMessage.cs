using System;
using GraphQl.Service.Entities;
using GraphQL.Types;

namespace GraphQlService.GraphQl.UserService.Messaging
{
    /// <summary>
    /// Wrapper Subscription Model class for the Test entity
    /// </summary>
    public class UserAddedMessage:ObjectGraphType<User>
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
