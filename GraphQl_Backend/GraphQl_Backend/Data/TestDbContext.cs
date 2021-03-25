using GraphQl_Backend.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace GraphQl_Backend.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {

        }

        public DbSet<Test> Tests { get; set; }
        public DbSet<TestResult> TestResults { get; set; }
    }

    public static class ContextExtesions
    {
        public static void Seed(this TestDbContext testDbContext)
        {
            AddTestsData(testDbContext);
            AddTestResultsData(testDbContext);
            testDbContext.SaveChanges();
        }

        private static void AddTestsData(TestDbContext testDbContext)
        {
            if (!testDbContext.Tests.Any())
            {
                testDbContext.Tests.AddRange(
                 new Test
                 {
                     Id = 1,
                     Name = "Manual-Inspection",
                     Description = "Code review by peers.",
                     Tester = "Stefan"
                 },
                  new Test
                  {
                      Id = 2,
                      Name = "Unit-Test",
                      Description = "Testing through unit tests.",
                      Tester = "Naveen"
                  },
                   new Test
                   {
                       Id = 3,
                       Name = "Integration-Test",
                       Description = "Integration Testing",
                       Tester = "Chee Hong"
                   },
                    new Test
                    {
                        Id = 4,
                        Name = "Manual-Testing",
                        Description = "Testing by manual tester.",
                        Tester = "Markus"
                    }
             );
            }
        }

        private static void AddTestResultsData(TestDbContext testDbContext)
        {
            if (!testDbContext.TestResults.Any())
            {
                for (int i = 1; i < 25; i++)
                {
                    testDbContext.TestResults.AddRange(
                         new TestResult
                         {
                             ResultId = "R"+i,
                             TestId = new Random().Next(1,4),
                             Verdict = (Verdict)new Random().Next(0, 3)
                         });
                }
            }
        }
    }
}
