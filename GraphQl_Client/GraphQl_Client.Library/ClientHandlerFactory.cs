using GraphQl_Client.Library.Client;

namespace GraphQl_Client.Library
{
    public class ClientHandlerFactory
    {
        public static IClientHandler GetClientHandler()
        {
            return new HttpBasedClientHandler();
        }
    }
}
