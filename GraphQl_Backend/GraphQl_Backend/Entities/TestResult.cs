using GraphQl_Backend.Enums;
using System.ComponentModel.DataAnnotations;

namespace GraphQl_Backend.Data
{
    public class TestResult
    {
        [Key]
        public string ResultId { get; set; }
        public int TestId { get; set; }
        public Verdict Verdict { get; set; }
    }

   
}