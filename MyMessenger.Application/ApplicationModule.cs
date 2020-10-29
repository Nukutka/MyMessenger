using MyMessenger.Application.Contracts;
using MyMessenger.EntityFramework;
using Volo.Abp.Modularity;

namespace MyMessenger.Application
{
    [DependsOn(
        typeof(ApplicationContractsModule),
        typeof(EntityFrameworkModule)
        )]
    public class ApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}
