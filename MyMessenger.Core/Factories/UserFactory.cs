using MyMessenger.Core.Factories.Abstraction;
using MyMessenger.Core.Services;
using MyMessenger.Domain.Entities.Users;
using MyMessenger.Domain.Shared.Enums.Users;
using System;

namespace MyMessenger.Core.Factories
{
    public class UserFactory : BaseFactory
    {
        public UserFactory(ArgumentChecker argumentChecker)
            : base(argumentChecker)
        {

        }

        public UserInfo CreateUserInfo(string firstname, string lastname, string email, UserActiveStatuses activeStatus, Guid userId)
        {
            argumentChecker.CheckNullArgument(() => firstname);
            argumentChecker.CheckNullArgument(() => lastname);
            argumentChecker.CheckNullArgument(() => email);

            return new UserInfo(guidGenerator.Create())
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
            argumentChecker.CheckNullArgument(() => login);
            argumentChecker.CheckNullArgument(() => hashPassword);
            argumentChecker.CheckNullArgument(() => userInfo);

            return new User(guidGenerator.Create())
            {
                Login = login,
                HashPassword = hashPassword,
                UserInfo = userInfo
            };
        }

        public User CreateUser(string login, string hashPassword)
        {
            argumentChecker.CheckNullArgument(() => login);
            argumentChecker.CheckNullArgument(() => hashPassword);

            return new User(guidGenerator.Create())
            {
                Login = login,
                HashPassword = hashPassword
            };
        }
    }
}
