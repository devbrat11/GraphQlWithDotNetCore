using System;
using System.Reactive.Subjects;
using GraphQlService.Data;

namespace GraphQlService.GraphQl.Messaging
{
    /// <summary>
    /// Messaging service class for handling subscriptions for the Tests updation
    /// </summary>
    public class TestUpdatesMessagingService
    {
        private ISubject<TestAddedMessage> _testMessageStream = new ReplaySubject<TestAddedMessage>();

        public TestAddedMessage AddTestAddedMessage(Test test)
        {
            var testAddedMessage = new TestAddedMessage()
            {
                Id = test.Id,
                Name = test.Name,
                Tester = test.Tester,
            };
            _testMessageStream.OnNext(testAddedMessage);
            return testAddedMessage;
        }

        public IObservable<TestAddedMessage> GetMessages()
        {
            return _testMessageStream;
        }
    }
   
}
