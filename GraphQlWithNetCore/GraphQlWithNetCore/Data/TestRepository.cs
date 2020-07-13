using System.Collections.Generic;
using System.Linq;

namespace GraphQlWithNetCore.Data
{
    public class TestRepository:IRepository
    {
        private TestDbContext _context;

        public TestRepository(TestDbContext context)
        {
            _context = context;
        }

        public TestResult AddTestResult(TestResult testResult)
        {
            _context.TestResults.Add(testResult);
            _context.SaveChanges();
            return testResult;
        }

        public Test CreateTest(Test test)
        {
            _context.Tests.Add(test);
            _context.SaveChanges();
            return test;
        }

        public IEnumerable<Test> GetAllTests()
        {
            return _context.Tests;
        }

        public Test GetTest(int id)
        {
            var test = _context.Tests.ToList().First(x=>x.Id.Equals(id));
            return test;
        }

        public IEnumerable<TestResult> GetTestResults(int testId)
        {
            var testResults = _context.TestResults.ToList().Where(x => x.TestId.Equals(testId));
            return testResults;
        }
    }
}
