using MyMessenger.Application.Contracts;
using MyMessenger.EntityFramework;
using MyMessenger.Security;
using Volo.Abp.Modularity;

namespace MyMessenger.Application
{
    [DependsOn(
        typeof(ApplicationContractsModule),
        typeof(EntityFrameworkModule),
        typeof(SecurityModule)
        )]
    public class ApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}
