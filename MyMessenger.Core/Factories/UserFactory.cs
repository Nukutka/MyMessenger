using MyMessenger.Core.Factories.Abstraction;
using MyMessenger.Domain.Entities.Users;
using MyMessenger.Domain.Shared.Enums.Users;
using System;

namespace MyMessenger.Core.Factories
{
    public class UserFactory : BaseFactory
    {
        public User CreateUser(string nickname, string role, string hashPassword, string firstname, string lastname, string email, UserActiveStatuses activeStatus)
        {
            ArgumentChecker.CheckNullArgument(() => nickname);
            ArgumentChecker.CheckNullArgument(() => role);
            ArgumentChecker.CheckNullArgument(() => hashPassword);
            ArgumentChecker.CheckNullArgument(() => firstname);
            ArgumentChecker.CheckNullArgument(() => lastname);
            ArgumentChecker.CheckNullArgument(() => email);

            var user = new User(GuidGenerator.Create())
            {
                Nickname = nickname,
                Role = role,
                HashPassword = hashPassword,
                Firstname = firstname,
                Lastname = lastname,
                Email = email,
                ActiveStatus = activeStatus,
            };

            return user;
        }

        public User CreateUser(Guid id, string nickname, string role, string hashPassword, string firstname, string lastname, string email, UserActiveStatuses activeStatus)
        {
            ArgumentChecker.CheckNullArgument(() => nickname);
            ArgumentChecker.CheckNullArgument(() => role);
            ArgumentChecker.CheckNullArgument(() => hashPassword);
            ArgumentChecker.CheckNullArgument(() => firstname);
            ArgumentChecker.CheckNullArgument(() => lastname);
            ArgumentChecker.CheckNullArgument(() => email);

            var user = new User(id)
            {
                Nickname = nickname,
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
            return CreateUser(user.Nickname, user.Role, user.HashPassword, user.Firstname, user.Lastname, user.Email, user.ActiveStatus);
        }
    }
}
