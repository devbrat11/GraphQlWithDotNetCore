using System;
using System.Reactive.Subjects;
using GraphQl.Service.Model;

namespace GraphQlService.GraphQl.UserService.Messaging
{
    /// <summary>
    /// Messaging service class for handling subscriptions for the Tests updation
    /// </summary>
    public class UserMessagingService
    {
        private ISubject<UserAddedMessage> _userMessageStream = new ReplaySubject<UserAddedMessage>();

        public UserAddedMessage AddUserAddedMessage(UserRegistrationInfo user)
        {
            var userAddedMessage = new UserAddedMessage()
            {
                UserId = user.UserID,
                UserName = user.Name,
                DateOfBirth = user.DateOfBirth
            };
            _userMessageStream.OnNext(userAddedMessage);
            return userAddedMessage;
        }

        public IObservable<UserAddedMessage> GetMessages()
        {
            return _userMessageStream;
        }
    }
   
}
