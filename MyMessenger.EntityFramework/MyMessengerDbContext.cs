using Microsoft.EntityFrameworkCore;
using MyMessenger.Domain.Entities.AssociativeEntities;
using MyMessenger.Domain.Entities.Messaging;
using MyMessenger.Domain.Entities.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyMessenger.EntityFramework
{
    [ConnectionStringName("PostgreSql")]
    public class MyMessengerDbContext : AbpDbContext<MyMessengerDbContext>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<UserChatAssociation> UserChatAssociations { get; set; }

        public MyMessengerDbContext(DbContextOptions<MyMessengerDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
