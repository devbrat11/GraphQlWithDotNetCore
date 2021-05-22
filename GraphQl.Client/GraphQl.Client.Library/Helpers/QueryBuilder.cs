namespace GraphQlClient.Library.Helpers
{
    public class QueryBuilder
    {
        public static string GetAllUsersQuery()
        {
            var query = @"{users{pK name dateOfBirth emailID}}";
            return query;
        }

        public static string GetUserWithID(string emailID)
        {
            var query = @"user(userID:" + emailID + @"){pK name dateOfBirth emailID}";
            return query;
        }
    }
}
