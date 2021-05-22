using System;

namespace GraphQl.Service.Model
{
    public class UserRegistrationInfo
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
    }
}
