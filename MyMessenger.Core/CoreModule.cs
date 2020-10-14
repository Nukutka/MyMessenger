using MyMessenger.Domain;
using Volo.Abp.Modularity;

namespace MyMessenger.Core
{
    [DependsOn(
        typeof(DomainModule)
        )]
    public class CoreModule : AbpModule
    {
    }
}
