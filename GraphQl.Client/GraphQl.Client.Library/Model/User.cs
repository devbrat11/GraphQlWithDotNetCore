using System;
using System.Collections.Generic;

namespace GraphQlClient.Library.Model
{
    

    public class User
    {
        public Guid PK { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailID { get; set; }

        public void Show()
        {
            Console.WriteLine($"PK : {PK}, Name : {Name}, DateOfBirth : {DateOfBirth}, EmailID : {EmailID}");
        }
    }
}
