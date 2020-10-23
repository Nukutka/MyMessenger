using MyMessenger.Core;
using MyMessenger.EntityFramework;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace MyMessenger.Application
{
    [DependsOn(
        typeof(CoreModule),
        typeof(EntityFrameworkModule),
        typeof(AbpAutoMapperModule)
        )]
    public class ApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<ApplicationModule>();
            });
        }
    }
}
