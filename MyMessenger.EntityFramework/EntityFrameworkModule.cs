using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyMessenger.Core;
using MyMessenger.EntityFramework.DbContext;
using Volo.Abp.EntityFrameworkCore.PostgreSql;
using Volo.Abp.Modularity;

namespace MyMessenger.EntityFramework
{
    [DependsOn(
        typeof(AbpEntityFrameworkCorePostgreSqlModule),
        typeof(CoreModule)
        )]
    public class EntityFrameworkModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();

            var connectionString = configuration.GetConnectionString("PostgreSQL");
            var loggerFactory = context.Services.GetRequiredServiceLazy<ILoggerFactory>();

            context.Services.AddAbpDbContext<MyMessengerDbContext>(options =>
            {
                DbContextConfigurer.Configure(options, connectionString, loggerFactory);
            });
        }
    }
}
