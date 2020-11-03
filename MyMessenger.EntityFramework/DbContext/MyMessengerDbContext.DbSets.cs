using Microsoft.EntityFrameworkCore;
using MyMessenger.Domain.Entities.AssociativeEntities;
using MyMessenger.Domain.Entities.Messaging;
using MyMessenger.Domain.Entities.Users;

namespace MyMessenger.EntityFramework.DbContext
{
    public partial class MyMessengerDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<UserChatAssociation> UserChatAssociations { get; set; }
    }
}
