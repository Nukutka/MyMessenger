using MyMessenger.Core.Factories.Abstraction;
using MyMessenger.Domain.Entities.Users;
using MyMessenger.Domain.Shared.Enums.Users;
using System;

namespace MyMessenger.Core.Factories
{
    public class UserFactory : BaseFactory
    {
        public User CreateUser(string login, string role, string hashPassword, string firstname, string lastname, string email, UserActiveStatuses activeStatus)
        {
            ArgumentChecker.CheckNullArgument(() => login);
            ArgumentChecker.CheckNullArgument(() => role);
            ArgumentChecker.CheckNullArgument(() => hashPassword);
            ArgumentChecker.CheckNullArgument(() => firstname);
            ArgumentChecker.CheckNullArgument(() => lastname);
            ArgumentChecker.CheckNullArgument(() => email);

            var user = new User(GuidGenerator.Create())
            {
                Login = login,
                Role = role,
                HashPassword = hashPassword,
                Firstname = firstname,
                Lastname = lastname,
                Email = email,
                ActiveStatus = activeStatus,
            };

            return user;
        }

        public User CreateUser(Guid id, string login, string role, string hashPassword, string firstname, string lastname, string email, UserActiveStatuses activeStatus)
        {
            ArgumentChecker.CheckNullArgument(() => login);
            ArgumentChecker.CheckNullArgument(() => role);
            ArgumentChecker.CheckNullArgument(() => hashPassword);
            ArgumentChecker.CheckNullArgument(() => firstname);
            ArgumentChecker.CheckNullArgument(() => lastname);
            ArgumentChecker.CheckNullArgument(() => email);

            var user = new User(id)
            {
                Login = login,
                Role = role,
                HashPassword = hashPassword,
                Firstname = firstname,
                Lastname = lastname,
                Email = email,
                ActiveStatus = activeStatus,
            };

            return user;
        }

        public User CreateUser(User user)
        {
            return CreateUser(user.Login, user.Role, user.HashPassword, user.Firstname, user.Lastname, user.Email, user.ActiveStatus);
        }
    }
}
