using GraphQlUsingAspCoreDotNet.Enums;
using System.ComponentModel.DataAnnotations;

namespace GraphQlUsingAspCoreDotNet.Data
{
    public class TestResult
    {
        [Key]
        public string ResultId { get; set; }
        public int TestId { get; set; }
        public Verdict Verdict { get; set; }
    }

   
}