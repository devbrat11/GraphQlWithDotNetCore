using System;
using System.Collections.Generic;
using System.Linq;
using GraphQl.Service.Entities;
using GraphQl.Service.Model;

namespace GraphQlService.Data
{
    public class UserRepository:IUserRepository
    {
        private ServiceDbContext _context;

        public UserRepository(ServiceDbContext context)
        {
            _context = context;
        }

        public bool AddUser(UserRegistrationInfo userInfo)
        {
            if (IsUserExists(userInfo.EmailID))
            {
                return false;
            }
            var userDetails = userInfo.MapToEntity();

            _context.Users.Add(userDetails.Item1);
            _context.UserCredentials.Add(userDetails.Item2);
            _context.SaveChanges();
            return true;
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUser(string userId)
        {
            return _context.Users.FirstOrDefault(x => x.EmailID.Equals(userId));
        }

        public bool IsUserValid(LoginCredential userLoginCredentials)
        {
            var userCredentials = _context.UserCredentials.FirstOrDefault(x => x.UserID.Equals(userLoginCredentials.UserID));
            if (userCredentials != null)
            {
                if (userCredentials.Password.Equals(userLoginCredentials.Password))
                {
                    return true;
                }
            }
            return false;
        }

        public void UpdateUser(Guid pk, UserRegistrationInfo userInfo)
        {
            var user = _context.Users.FirstOrDefault(x => x.PK.Equals(pk));
            var updatedUserDetails = userInfo.MapToEntity();
            if (user != null)
            {
                user.Name = updatedUserDetails.Item1.Name;
                user.EmailID = updatedUserDetails.Item1.EmailID;
                user.DateOfBirth = updatedUserDetails.Item1.DateOfBirth;

                var userCredential = _context.UserCredentials.FirstOrDefault(x => x.UserID.Equals(user.EmailID));

                if (userCredential != null)
                {
                    userCredential.UserID = updatedUserDetails.Item2.UserID;
                    userCredential.Password = updatedUserDetails.Item2.Password;
                }
            }
        }

        private bool IsUserExists(string userId)
        {
            return _context.Users.Any(x => x.EmailID.Equals(userId));
        }
    }

    public static class Mapper
    {
        public static Tuple<User, LoginCredential> MapToEntity(this UserRegistrationInfo userInfo)
        {
            var user = new User()
            {
                Name = userInfo.Name,
                DateOfBirth = userInfo.DateOfBirth,
                EmailID = userInfo.EmailID,
            };
            var userCredentials = new LoginCredential()
            {
                UserID = userInfo.EmailID,
                Password = userInfo.Password
            };
            return new Tuple<User, LoginCredential>(user, userCredentials);
        }
    }
}
