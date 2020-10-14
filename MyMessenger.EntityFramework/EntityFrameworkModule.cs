using Microsoft.Extensions.DependencyInjection;
using MyMessenger.Core;
using Volo.Abp.EntityFrameworkCore;
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
            context.Services.AddAbpDbContext<MyMessengerDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);
            });

            Configure<AbpDbContextOptions>(options =>
            {
                options.UseNpgsql();
            });
        }
    }
}
