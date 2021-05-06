using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQl.Service.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PK { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserID { get; set; }
    }

    public class LoginCredential
    {
        [Key]
        public string UserID { get; set; }

        public string Password { get; set; }
    }
}
