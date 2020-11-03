using Microsoft.EntityFrameworkCore;
using MyMessenger.Domain.Entities.Users;

namespace MyMessenger.EntityFramework.DbContext.Extensions
{
    public static class FluentExtensions
    {
        public static ModelBuilder ConfigureUser(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(user =>
            {
                user.HasIndex(u => u.Login).IsUnique();
                user.HasIndex(u => u.Email).IsUnique();
            });

            return modelBuilder;
        }
    }
}
