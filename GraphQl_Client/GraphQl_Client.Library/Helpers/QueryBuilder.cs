namespace GraphQl_Client.Library.Helpers
{
    public class QueryBuilder
    {
        public static string GetAllTestsQuery()
        {
            var query = @"{tests{id name}}";
            return query;
        }
    }
}
