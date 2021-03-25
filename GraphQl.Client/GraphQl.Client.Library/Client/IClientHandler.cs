using System.Collections.Generic;
using GraphQlClient.Library.Model;

namespace GraphQlClient.Library.Client
{
    public interface IClientHandler
    {
        List<Test> GetAllTests();
        Test GetTest(int testId);
    }

   
}
