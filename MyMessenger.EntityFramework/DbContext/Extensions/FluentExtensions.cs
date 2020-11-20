using Microsoft.EntityFrameworkCore;
using MyMessenger.Domain.Entities.Messaging;
using MyMessenger.Domain.Entities.Users;

namespace MyMessenger.EntityFramework.DbContext.Extensions
{
    public static class FluentExtensions
    {
        public static ModelBuilder ConfigureUser(this ModelBuilder modelBuilder)
        {
            return modelBuilder.Entity<User>(user =>
            {
                user.Property(u => u.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                user.Property(u => u.Nickname)
                    .IsRequired()
                    .HasMaxLength(40);

                user.Property(u => u.Firstname)
                    .IsRequired()
                    .HasMaxLength(40);

                user.Property(u => u.Lastname)
                    .IsRequired()
                    .HasMaxLength(40);

                user.Property(u => u.Role)
                    .IsRequired();

                user.Property(u => u.HashPassword)
                    .IsRequired();

                user.Property(u => u.ActiveStatus)
                    .IsRequired();

                user.HasIndex(u => u.Email)
                    .IsUnique();

                user.HasIndex(u => u.Nickname)
                    .IsUnique();
            });
        }

        public static ModelBuilder ConfigureChat(this ModelBuilder modelBuilder)
        {
            return modelBuilder.Entity<Chat>(chat =>
            {
                chat.Property(c => c.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });
        }

        public static ModelBuilder ConfigureMessage(this ModelBuilder modelBuilder)
        {
            return modelBuilder.Entity<Message>(message =>
            {
                message.Property(m => m.Body)
                    .HasMaxLength(4096);
            });
        }

        public static ModelBuilder ConfigureAttachment(this ModelBuilder modelBuilder)
        {
            return modelBuilder.Entity<Attachment>(attachment =>
            {
                // TODO:
            });
        }
    }
}
