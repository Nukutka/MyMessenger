using Microsoft.Extensions.DependencyInjection;
using MyMessenger.Core.Services;
using MyMessenger.Core.Services.Abstraction;
using MyMessenger.Domain;
using Volo.Abp.Modularity;

namespace MyMessenger.Core
{
    [DependsOn(
        typeof(DomainModule)
        )]
    public class CoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddTransient<IArgumentChecker, ArgumentChecker>();
            context.Services.AddTransient<IExceptionManager, ExceptionManager>();
        }
    }
}
