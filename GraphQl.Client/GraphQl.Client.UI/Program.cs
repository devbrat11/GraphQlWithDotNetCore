using System;
using GraphQlClient.Library;

namespace GraphQlClient.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = ClientHandlerFactory.GetClientHandler(ClientHandler.GraphQlBased);
            while (true)
            {
                var choice = GetUserChoice();
                if (choice == 1)
                {
                    var users = client.GetAllUsers();

                    users.ForEach(x => x.Show());
                }
                else if (choice == 2)
                {
                    Console.Write("Enter Email ID : ");
                    var emailID = Console.ReadLine();
                    var test = client.GetUser(emailID);
                    test.Show();
                }
                else
                {
                    Console.WriteLine("Choice not available.");
                }
               
            }
        }

        private static int GetUserChoice()
        {
            Console.WriteLine("1. Get All Users");
            Console.WriteLine("2. User with EmailID");
            Console.Write("Enter your choice : ");
            var choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }


}
