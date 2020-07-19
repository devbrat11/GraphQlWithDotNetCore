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

        public void AddTestResult(TestResult testResult)
        {
            _context.TestResults.Add(testResult);
            _context.SaveChanges();
        }

        public void CreateTest(Test test)
        {
            _context.Tests.Add(test);
            _context.SaveChanges();
        }

        public bool DeleteTest(int testId)
        {
            var test = _context.Tests.FirstOrDefault(x => x.Id.Equals(testId));
            if (test!=null)
            {
                _context.Tests.Remove(test);
                _context.TestResults.RemoveRange(_context.TestResults.Where(x => x.TestId.Equals(testId)));
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<TestResult> GetAllTestResults()
        {
            return _context.TestResults;
        }

        public IEnumerable<Test> GetAllTests()
        {
            return _context.Tests;
        }

        public Test GetTest(int id)
        {
            var test = _context.Tests.ToList().FirstOrDefault(x=>x.Id.Equals(id));
            return test;
        }

        public IEnumerable<TestResult> GetTestResults(int testId)
        {
            var testResults = _context.TestResults.ToList().Where(x => x.TestId.Equals(testId));
            return testResults;
        }

        public bool UpdateTest(int testId, Test test)
        {
            var testToUpdate = _context.Tests.FirstOrDefault(x => x.Id.Equals(testId));
            if (testToUpdate != null)
            {
                _context.Tests.Remove(testToUpdate);
                _context.Tests.Add(test);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
