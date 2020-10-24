using Microsoft.EntityFrameworkCore;
using MyMessenger.Domain.Entities.Messaging;
using MyMessenger.EntityFramework.Seeds.Abstraction;
using System.Collections.Generic;
using Volo.Abp.Guids;

namespace MyMessenger.EntityFramework.Seeds
{
    public static class ChatSeed
    {
        private static readonly IGuidGenerator guidGenerator;

        static ChatSeed()
        {
            guidGenerator = BaseSeed.GuidGenerator;
        }

        public static List<Chat> AddChats(this ModelBuilder modelBuilder)
        {
            var chats = new List<Chat>
            {
                new Chat(guidGenerator.Create())
                {
                    Name = "Chat 1"
                },
                new Chat(guidGenerator.Create())
                {
                    Name = "Chat 2"
                }
            };

            modelBuilder.Entity<Chat>()
                .HasData(chats);

            return chats;
        }
    }
}
