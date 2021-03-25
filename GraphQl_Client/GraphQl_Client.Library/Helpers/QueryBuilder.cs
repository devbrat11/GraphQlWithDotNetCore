namespace GraphQl_Client.Library.Helpers
{
    public class QueryBuilder
    {
        public static string GetAllTestsQuery()
        {
            var query = @"{tests{id name}}";
            return query;
        }

        public static string GetTestForIdQuery(int testID)
        {
            var query = @"test(id:"+testID+@"){id name tester description results{resultId verdict}}";
            return query;
        }
    }
}
