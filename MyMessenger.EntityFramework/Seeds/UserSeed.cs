using Microsoft.EntityFrameworkCore;
using MyMessenger.Core.Factories;
using MyMessenger.Core.Services.Utils;
using MyMessenger.Domain.Entities.Users;
using MyMessenger.Domain.Shared.Enums.Users;
using MyMessenger.EntityFramework.Seeds.Abstraction;
using MyMessenger.Security.Hash.Abstraction;
using System.Collections.Generic;

namespace MyMessenger.EntityFramework.Seeds
{
    public static class UserSeed 
    {
        private static readonly UserFactory userFactory;
        private static readonly IHashFunction hashFunction;

        static UserSeed()
        {
            userFactory = FactoryCreator.GetFactory<UserFactory>();
            hashFunction = BaseSeed.hashFunction;
        }

        public static List<User> AddUsers(this ModelBuilder modelBuilder)
        {
            var user = userFactory.CreateUser("user1", hashFunction.GetHashCode("user1"));
            var userInfo = userFactory.CreateUserInfo("Nikita", "Nagovitsyn", "test@test.com", UserActiveStatuses.Offline, user.Id);

            var user2 = userFactory.CreateUser("user2", hashFunction.GetHashCode("user2"));
            var userInfo2 = userFactory.CreateUserInfo("Darya", "Shigabytdinova", "test2@test.com", UserActiveStatuses.Offline, user2.Id);

            var userInfos = new List<UserInfo>
            {
                userInfo,
                userInfo2
            };

            var users = new List<User>
            {
                user,
                user2
            };

            modelBuilder.Entity<UserInfo>()
                .HasData(userInfos);

            modelBuilder.Entity<User>()
                .HasData(users);

            return users;
        }
    }
}
