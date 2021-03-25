using System.Collections.Generic;

namespace GraphQlService.Data
{
    public interface IRepository
    {
        IEnumerable<Test> GetAllTests();
        Test GetTest(int id);
        IEnumerable<TestResult> GetAllTestResults();
        IEnumerable<TestResult> GetTestResults(int testId);
        void CreateTest(Test test);
        void AddTestResult(TestResult testResult);
        bool UpdateTest(int testId, Test test);
        bool DeleteTest(int testId);
    }
}