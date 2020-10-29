using Microsoft.EntityFrameworkCore;

namespace MyMessenger.EntityFramework.DbContext
{
    public static class Automigrator 
    {
        public static void Migrate(string connectionString)
        {
            using var context = CreateDbContext(connectionString);
            context.Database.Migrate();
        }

        private static MyMessengerDbContext CreateDbContext(string connectionString)
        {
            var builder = new DbContextOptionsBuilder<MyMessengerDbContext>();
            builder.UseNpgsql(connectionString, options => options.MigrationsAssembly("MyMessenger.EntityFramework"));

            return new MyMessengerDbContext(builder.Options);
        }
    }
}
