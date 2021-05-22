using GraphQlClient.Library.Model;
using System;
using System.Collections.Generic;

namespace GraphQl.Client.Library.Model
{
    public class UserData
    {
        public List<User> Users { get; set; }

        public void Show()
        {
            Console.WriteLine("Users : ");
            foreach (var user in Users)
            {
                Console.WriteLine($"PK : {user.PK}, Name : {user.Name}, DateOfBirth : {user.DateOfBirth}, EmailID : {user.EmailID}");
            }
        }
    }
}
