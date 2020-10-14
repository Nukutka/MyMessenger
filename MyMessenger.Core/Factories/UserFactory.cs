using MyMessenger.Core.Factories.Abstraction;
using MyMessenger.Core.Services;
using MyMessenger.Domain.Entities.Users;
using MyMessenger.Domain.Shared.Enums.Users;

namespace MyMessenger.Core.Factories
{
    public class UserFactory : BaseFactory
    {
        private readonly ArgumentChecker argumentChecker;

        public UserFactory(ArgumentChecker argumentChecker)
        {
            this.argumentChecker = argumentChecker;
        }

        public UserInfo CreateUserInfo(string firstname, string lastname, int age, string email, UserActiveStatuses activeStatus)
        {
            argumentChecker.CheckNullArgument(() => firstname);
            argumentChecker.CheckNullArgument(() => lastname);
            argumentChecker.CheckNullArgument(() => email);

            return new UserInfo(guidGenerator.Create())
            {
                Firstname = firstname,
                Lastname = lastname,
                Age = age,
                Email = email,
                ActiveStatus = activeStatus,
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
    }
}
