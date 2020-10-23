using Microsoft.EntityFrameworkCore;
using MyMessenger.Core.Factories;
using MyMessenger.Core.Services.Utils;
using MyMessenger.Domain.Entities.AssociativeEntities;
using MyMessenger.Domain.Entities.Messaging;
using MyMessenger.Domain.Entities.Users;
using System;
using System.Collections.Generic;

namespace MyMessenger.EntityFramework.Seeds
{
    public static class UserChatAssociationSeed
    {
        private readonly static AssociationsFactory associationFactory;

        static UserChatAssociationSeed()
        {
            associationFactory = FactoryCreator.GetFactory<AssociationsFactory>();
        }

        public static List<UserChatAssociation> AddUserChatAssociations(this ModelBuilder modelBuilder, List<User> users, List<Chat> chats)
        {
            Func<string, Guid> getUserIdByLogin = login => users.Find(u => u.Login == login).Id;
            Func<string, Guid> getChatIdByName = name => chats.Find(u => u.Name == name).Id;

            var userChatAssociations = new List<UserChatAssociation>
            {
                associationFactory.CreateUserChatAssociation(getUserIdByLogin("user1"), getChatIdByName("Chat 1")),
                associationFactory.CreateUserChatAssociation(getUserIdByLogin("user2"), getChatIdByName("Chat 1")),
                associationFactory.CreateUserChatAssociation(getUserIdByLogin("user1"), getChatIdByName("Chat 2")),
                associationFactory.CreateUserChatAssociation(getUserIdByLogin("user2"), getChatIdByName("Chat 2")),
            };

            modelBuilder.Entity<UserChatAssociation>()
                .HasData(userChatAssociations);

            return userChatAssociations;
        }
    }
}
