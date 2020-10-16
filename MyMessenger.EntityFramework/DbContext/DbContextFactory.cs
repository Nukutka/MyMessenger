using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyMessenger.Core.Configuration;

namespace MyMessenger.EntityFramework.DbContext
{
    public class DbContextFactory : IDesignTimeDbContextFactory<MyMessengerDbContext>
    {
        public MyMessengerDbContext CreateDbContext(string[] args)
        {
            var configuration = AppConfigManager.Get();
            var builder = new DbContextOptionsBuilder<MyMessengerDbContext>()
                .UseNpgsql(configuration.GetConnectionString("PostgreSql"), options => options.MigrationsAssembly("MyMessenger.EntityFramework"));

            return new MyMessengerDbContext(builder.Options);
        }
    }
}
