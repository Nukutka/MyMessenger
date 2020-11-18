using Microsoft.EntityFrameworkCore;
using MyMessenger.Domain.Entities.Messaging;
using MyMessenger.Domain.Entities.Users;
using MyMessenger.EntityFramework.Seeds.Abstraction;
using System;
using System.Collections.Generic;
using Volo.Abp.Guids;

namespace MyMessenger.EntityFramework.Seeds
{
    public static class MessageSeed
    {
        private static readonly IGuidGenerator guidGenerator;

        static MessageSeed()
        {
            guidGenerator = BaseSeed.GuidGenerator;
        }

        public static List<Message> AddMessages(this ModelBuilder modelBuilder, List<User> users, List<Chat> chats)
        {
            Func<string, Guid> getUserIdByLogin = nickname => users.Find(u => u.Nickname == nickname).Id;
            Func<string, Guid> getChatIdByName = name => chats.Find(u => u.Name == name).Id;

            var messages = new List<Message>(20);

            for (int i = 0; i < 5; i++)
            {
                var message = new Message(guidGenerator.Create())
                {
                    Body = $"Message {i + 1}",
                    UserId = getUserIdByLogin("Nukutka"),
                    ChatId = getChatIdByName("Chat 1")
                };

                messages.Add(message);
            }

            for (int i = 5; i < 10; i++)
            {
                var message = new Message(guidGenerator.Create())
                {
                    Body = $"Message {i + 1}",
                    UserId = getUserIdByLogin("Dashasexy"),
                    ChatId = getChatIdByName("Chat 1")
                };

                messages.Add(message);
            }

            for (int i = 10; i < 15; i++)
            {
                var message = new Message(guidGenerator.Create())
                {
                    Body = $"Message {i + 1}",
                    UserId = getUserIdByLogin("Nukutka"),
                    ChatId = getChatIdByName("Chat 2")
                };

                messages.Add(message);
            }

            for (int i = 15; i < 20; i++)
            {
                var message = new Message(guidGenerator.Create())
                {
                    Body = $"Message {i + 1}",
                    UserId = getUserIdByLogin("Dashasexy"),
                    ChatId = getChatIdByName("Chat 2")
                };

                messages.Add(message);
            }

            modelBuilder.Entity<Message>()
                .HasData(messages);

            return messages;
        }
    }
}
