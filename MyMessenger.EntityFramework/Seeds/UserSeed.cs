using Microsoft.EntityFrameworkCore;
using MyMessenger.Domain.Entities.Users;
using MyMessenger.Domain.Shared.Constants;
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
            var users = new List<User>
            {
                new User(guidGenerator.Create())
                {
                    Login = "user1",
                    Role = UserRoles.User,
                    HashPassword = hashFunction.GenerateHashCode("user1"),
                    Firstname = "Nikita",
                    Lastname = "Nagovitsyn",
                    Email = "test@test.com",
                    ActiveStatus = UserActiveStatuses.Offline,
                },

                new User(guidGenerator.Create())
                {
                    Login = "user2",
                    Role = UserRoles.User,
                    HashPassword = hashFunction.GenerateHashCode("user2"),
                    Firstname = "Darya",
                    Lastname = "Shigabytdinova",
                    Email = "test2@test.com",
                    ActiveStatus = UserActiveStatuses.Offline,
                }
            };

            modelBuilder.Entity<User>()
                .HasData(users);

            return users;
        }
    }
}
