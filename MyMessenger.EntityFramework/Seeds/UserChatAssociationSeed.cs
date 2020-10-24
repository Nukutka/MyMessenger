using Microsoft.EntityFrameworkCore;
using MyMessenger.Core.Factories;
using MyMessenger.Core.Services.Utils;
using MyMessenger.Domain.Entities.AssociativeEntities;
using MyMessenger.Domain.Entities.Messaging;
using MyMessenger.Domain.Entities.Users;
using MyMessenger.EntityFramework.Seeds.Abstraction;
using System;
using System.Collections.Generic;
using Volo.Abp.Guids;

namespace MyMessenger.EntityFramework.Seeds
{
    public static class UserChatAssociationSeed
    {
        private readonly static IGuidGenerator guidGenerator;

        static UserChatAssociationSeed()
        {
            guidGenerator = BaseSeed.GuidGenerator;
        }

        public static List<UserChatAssociation> AddUserChatAssociations(this ModelBuilder modelBuilder, List<User> users, List<Chat> chats)
        {
            Func<string, Guid> getUserIdByLogin = login => users.Find(u => u.Login == login).Id;
            Func<string, Guid> getChatIdByName = name => chats.Find(u => u.Name == name).Id;

            var userChatAssociations = new List<UserChatAssociation>
            {
                new UserChatAssociation(guidGenerator.Create())
                {
                    UserId = getUserIdByLogin("user1"),
                    ChatId = getChatIdByName("Chat 1")
                },
                                
                new UserChatAssociation(guidGenerator.Create())
                {
                    UserId = getUserIdByLogin("user2"),
                    ChatId = getChatIdByName("Chat 1")
                },               
                new UserChatAssociation(guidGenerator.Create())
                {
                    UserId = getUserIdByLogin("user1"),
                    ChatId = getChatIdByName("Chat 2")
                },                
                new UserChatAssociation(guidGenerator.Create())
                {
                    UserId = getUserIdByLogin("user1"),
                    ChatId = getChatIdByName("Chat 2")
                },
            };

            modelBuilder.Entity<UserChatAssociation>()
                .HasData(userChatAssociations);

            return userChatAssociations;
        }
    }
}
