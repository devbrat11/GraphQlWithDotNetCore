using GraphQl_Client.Library;

namespace GraphQl_Client.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = ClientHandlerFactory.GetClientHandler();
            var tests = client.GetAllTests();
        }
    }

    
}
