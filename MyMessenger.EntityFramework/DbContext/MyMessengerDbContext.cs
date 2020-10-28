using Microsoft.EntityFrameworkCore;
using MyMessenger.EntityFramework.Seeds;
using Volo.Abp.EntityFrameworkCore;

namespace MyMessenger.EntityFramework.DbContext
{
    public partial class MyMessengerDbContext : AbpDbContext<MyMessengerDbContext>
    {
        public MyMessengerDbContext(DbContextOptions<MyMessengerDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var users = modelBuilder.AddUsers();
            var chats = modelBuilder.AddChats();
            var messages = modelBuilder.AddMessages(users, chats);
            var userChatAssociations = modelBuilder.AddUserChatAssociations(users, chats);
        }
    }
}
