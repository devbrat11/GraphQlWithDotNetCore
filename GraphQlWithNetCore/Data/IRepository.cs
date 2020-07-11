using System.Collections.Generic;

namespace GraphQlWithNetCore.Data
{
    public interface IRepository
    {
        IEnumerable<Test> GetAllTests();
        Test GetTest(int id);
        IEnumerable<TestResult> GetTestResults(int testId);
    }
}