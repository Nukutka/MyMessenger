using MyMessenger.Core.Factories.Abstraction;
using MyMessenger.Domain.Entities.Users;
using MyMessenger.Domain.Shared.Enums.Users;
using System;

namespace MyMessenger.Core.Factories
{
    public class UserFactory : BaseFactory
    {
        public UserInfo CreateUserInfo(string firstname, string lastname, string email, UserActiveStatuses activeStatus, Guid userId)
        {
            ArgumentChecker.CheckNullArgument(() => firstname);
            ArgumentChecker.CheckNullArgument(() => lastname);
            ArgumentChecker.CheckNullArgument(() => email);

            return new UserInfo(GuidGenerator.Create())
            {
                Firstname = firstname,
                Lastname = lastname,
                Email = email,
                ActiveStatus = activeStatus,
                UserId = userId
            };
        }

        public User CreateUser(string login, string hashPassword, UserInfo userInfo)
        {
            ArgumentChecker.CheckNullArgument(() => login);
            ArgumentChecker.CheckNullArgument(() => hashPassword);

            return new User(GuidGenerator.Create())
            {
                Login = login,
                HashPassword = hashPassword,
                UserInfo = userInfo
            };
        }

        public User CreateUser(string login, string hashPassword, string firstname, string lastname, string email, UserActiveStatuses activeStatus)
        {
            ArgumentChecker.CheckNullArgument(() => login);
            ArgumentChecker.CheckNullArgument(() => hashPassword);

            var user = new User(GuidGenerator.Create())
            {
                Login = login,
                HashPassword = hashPassword
            };

            var userInfo = CreateUserInfo(firstname, lastname, email, activeStatus, user.Id);
            user.UserInfo = userInfo;

            return user;
        }

        public User CreateUser(User user)
        {
            var userInfo = user.UserInfo;
            return CreateUser(user.Login, user.HashPassword, userInfo.Firstname, userInfo.Lastname, userInfo.Email, userInfo.ActiveStatus);
        }
    }
}
