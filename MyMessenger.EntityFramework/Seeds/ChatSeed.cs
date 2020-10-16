using Microsoft.EntityFrameworkCore;
using MyMessenger.Core.Factories;
using MyMessenger.Core.Services;
using MyMessenger.Domain.Entities.Messaging;
using System.Collections.Generic;

namespace MyMessenger.EntityFramework.Seeds
{
    public static class ChatSeed
    {
        private static readonly MessagingFactory messagingFactory;

        static ChatSeed()
        {
            messagingFactory = FactoryCreator.GetFactory<MessagingFactory>();
        }

        public static List<Chat> AddChats(this ModelBuilder modelBuilder)
        {
            var chats = new List<Chat>
            {
                messagingFactory.CreateChat("Chat 1"),
                messagingFactory.CreateChat("Chat 2"),
            };

            modelBuilder.Entity<Chat>()
                .HasData(chats);

            return chats;
        }
    }
}
