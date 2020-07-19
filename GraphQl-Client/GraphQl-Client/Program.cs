using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace GraphQl_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new GraphQlClientHandler();
            var tests = client.GetAllTests();
        }
    }

    
}
