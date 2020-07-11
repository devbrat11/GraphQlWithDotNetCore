using System.Collections.Generic;

namespace GraphQlUsingAspCoreDotNet.Data
{
    public interface IRepository
    {
        IEnumerable<Test> GetAllTests();
        Test GetTest(int id);
        IEnumerable<TestResult> GetTestResults(int testId);
    }
}