using System.Collections.Generic;
using GraphQl_Client.Library.Model;

namespace GraphQl_Client.Library.Client
{
    public interface IClientHandler
    {
        List<Test> GetAllTests();
        Test GetTest(int testId);
    }

   
}
