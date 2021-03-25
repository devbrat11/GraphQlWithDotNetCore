using System;
using System.Collections.Generic;
using GraphQlClient.Library;
using GraphQlClient.Library.Model;

namespace GraphQlClient.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = ClientHandlerFactory.GetClientHandler(1);
            List<Test> tests = null;
            while (true)
            {
                ShowOptions();
                var choice = GetUserChoice();
                if (choice == 1)
                {
                    tests = client.GetAllTests();
                }
                else if (choice == 2)
                {
                    Console.Write("Enter Test ID : ");
                    var testId = int.Parse(Console.ReadLine());
                    var test = client.GetTest(testId);
                    tests = new List<Test>
                {
                    test
                };
                }
                else
                {
                    Console.WriteLine("Choice not available.");
                }
                if (tests != null)
                {
                    ShowTestDetails(tests);
                }
            }
        }

        private static void ShowOptions()
        {
            Console.WriteLine("1. Get All Tests");
            Console.WriteLine("2. Test with ID");
            Console.Write("Enter your choice : ");
        }

        private static int GetUserChoice()
        {
            var choice = int.Parse(Console.ReadLine());
            return choice;
        }

        private static void ShowTestDetails(List<Test> tests)
        {
            Console.WriteLine("TestResults : ");
            foreach (var test in tests)
            {
                Console.WriteLine($"ID : {test.Id}, Name : {test.Name}, Tester : {test.Tester}, Description : {test.Description}");
                if (test.Results != null)
                {
                    foreach (var result in test.Results)
                    {
                        Console.WriteLine($"ResultID : {result.ResultId}, Verdict : {result.Verdict}");
                    }
                }
            }
        }
    }


}
