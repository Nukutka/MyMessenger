using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.DependencyInjection;

namespace MyMessenger.EntityFramework.DbContext
{
    public static class DbContextConfigurer
    {
        public static void Configure(
            IAbpDbContextRegistrationOptionsBuilder optionsBuilder,
            string connectionString)
        {
            optionsBuilder.AddDefaultRepositories(includeAllEntities: true);

            optionsBuilder.Services.Configure<AbpDbContextOptions>(abpDbContextOptions =>
            {
                abpDbContextOptions.Configure(configContext =>
                {
                    var builder = configContext.DbContextOptions;
                    builder.EnableSensitiveDataLogging();
                    builder.UseNpgsql(connectionString, x => x.MigrationsAssembly("MyMessenger.EntityFramework"));
                });
            });
        }
    }
}
