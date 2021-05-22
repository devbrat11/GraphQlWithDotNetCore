using GraphQlClient.Library.Client;

namespace GraphQlClient.Library
{
    public class ClientHandlerFactory
    {
        public static IClientHandler GetClientHandler(ClientHandler clientHandler)
        {
            if (clientHandler == ClientHandler.HttpClientBased)
            {
                return new HttpBasedClientHandler();
            }
            else
            {
                return new GraphQlClientHandler();
            }

        }
    }

    public enum ClientHandler
    {
        HttpClientBased,
        GraphQlBased
    }
}
