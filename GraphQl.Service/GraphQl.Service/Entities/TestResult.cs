using GraphQlService.Enums;
using System.ComponentModel.DataAnnotations;

namespace GraphQlService.Data
{
    public class TestResult
    {
        [Key]
        public string ResultId { get; set; }
        public int TestId { get; set; }
        public Verdict Verdict { get; set; }
    }

   
}