using GraphQl.Service.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GraphQlService.Data
{
    public class ServiceDbContext : DbContext
    {
        public ServiceDbContext(DbContextOptions<ServiceDbContext> options) : base(options)
        {
            this.Seed();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<LoginCredential> UserCredentials { get; set; }
    }

    public static class ContextExtensions
    {
        public static void Seed(this ServiceDbContext dbContext)
        {
            AddUserData(dbContext);
            dbContext.SaveChanges();
        }

        private static void AddUserData(ServiceDbContext dbContext)
        {
            if (!dbContext.Users.Any())
            {
                dbContext.Users.AddRange(
                 new User
                 {
                     EmailID = "abc1@graphqlservice.com",
                     Name = "Devbrat Singh",
                     DateOfBirth = new System.DateTime(1993,07,11),
                 },
                  new User
                  {
                      EmailID = "abc2@graphqlservice.com",
                      Name = "Anoop Sharma",
                      DateOfBirth = new System.DateTime(1993, 07, 11),
                  },
                   new User
                   {
                       EmailID = "abc3@graphqlservice.com",
                       Name = "Anshul Jain",
                       DateOfBirth = new System.DateTime(1993, 07, 11),
                   }
             );
            }

            if (!dbContext.UserCredentials.Any())
            {
                dbContext.UserCredentials.AddRange(
                 new LoginCredential
                 {
                     UserID = "abc1@graphqlservice.com",
                     Password = "test1234",
                 },
                  new LoginCredential
                  {
                      UserID = "abc2@graphqlservice.com",
                      Password = "test1234",
                  },
                   new LoginCredential
                   {
                       UserID = "abc3@graphqlservice.com",
                       Password = "test1234",
                   }
             );
            }
        }

    }
}
