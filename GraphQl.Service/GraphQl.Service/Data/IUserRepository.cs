using System;
using System.Collections.Generic;
using GraphQl.Service.Entities;
using GraphQl.Service.Model;

namespace GraphQlService.Data
{
    public interface IUserRepository
    {
        bool AddUser(UserRegistrationInfo userInfo);

        void UpdateUser(Guid pk, UserRegistrationInfo userInfo);

        User GetUser(string userId);

        List<User> GetAllUsers();

        bool IsUserValid(LoginCredential userLoginCredentials);
    }
}