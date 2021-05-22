using System.Collections.Generic;
using GraphQlClient.Library.Model;

namespace GraphQlClient.Library.Client
{
    public interface IClientHandler
    {
        List<User> GetAllUsers();
        User GetUser(string emailID);
    }

   
}
