using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQl_Client.Library.Model
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tester { get; set; }
        public string Description { get; set; }
        public List<TestResult> Results { get; set; }
    }

    public class TestResult
    {
        public string ResultId { get; set; }
        public int TestId { get; set; }
        public Verdict Verdict { get; set; }
    }

    public enum Verdict
    {
        Pass,
        Fail,
        Aborted,
        Error
    }
}
