using MyMessenger.Core;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace MyMessenger.Application.Contracts
{
    [DependsOn(
        typeof(CoreModule),
        typeof(AbpAutoMapperModule)
        )]
    public class ApplicationContractsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<ApplicationContractsModule>();
            });
        }
    }
}
