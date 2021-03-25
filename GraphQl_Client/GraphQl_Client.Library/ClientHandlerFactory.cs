using GraphQl_Client.Library.Client;

namespace GraphQl_Client.Library
{
    public class ClientHandlerFactory
    {
        public static IClientHandler GetClientHandler(int handler)
        {
            if (handler == 0)
            {
                return new HttpBasedClientHandler();
            }
            else
            {
                return new GraphQlClientHandler();
            }

        }
    }
}
