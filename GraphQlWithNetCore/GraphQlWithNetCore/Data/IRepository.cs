using System.Collections.Generic;

namespace GraphQlWithNetCore.Data
{
    public interface IRepository
    {
        IEnumerable<Test> GetAllTests();
        Test GetTest(int id);
        IEnumerable<TestResult> GetAllTestResults();
        IEnumerable<TestResult> GetTestResults(int testId);
        Test CreateTest(Test test);
        TestResult AddTestResult(TestResult testResult);
        bool UpdateTest(int testId, Test test);
        bool DeleteTest(int testId);
    }
}