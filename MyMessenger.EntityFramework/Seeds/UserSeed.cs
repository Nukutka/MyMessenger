using Microsoft.EntityFrameworkCore;
using MyMessenger.Domain.Entities.Users;
using MyMessenger.Domain.Shared.Enums.Users;
using MyMessenger.EntityFramework.Seeds.Abstraction;
using MyMessenger.Security.Hash.Abstraction;
using System.Collections.Generic;
using Volo.Abp.Guids;

namespace MyMessenger.EntityFramework.Seeds
{
    public static class UserSeed 
    {
        private static readonly IGuidGenerator guidGenerator;
        private static readonly IHashFunction hashFunction;

        static UserSeed()
        {
            guidGenerator = BaseSeed.GuidGenerator;
            hashFunction = BaseSeed.HashFunction;
        }

        public static List<User> AddUsers(this ModelBuilder modelBuilder)
        {
            var user = new User(guidGenerator.Create())
            {
                Login = "user1",
                HashPassword = hashFunction.GetHashCode("user1")
            };

            var userInfo = new UserInfo(guidGenerator.Create())
            {
                Firstname = "Nikita",
                Lastname = "Nagovitsyn",
                Email = "test@test.com",
                ActiveStatus = UserActiveStatuses.Offline,
                UserId = user.Id
            };

            var user2 = new User(guidGenerator.Create())
            {
                Login = "user2",
                HashPassword = hashFunction.GetHashCode("user2")
            };

            var userInfo2 = new UserInfo(guidGenerator.Create())
            {
                Firstname = "Darya",
                Lastname = "Shigabytdinova",
                Email = "test2@test.com",
                ActiveStatus = UserActiveStatuses.Offline,
                UserId = user2.Id
            };

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
