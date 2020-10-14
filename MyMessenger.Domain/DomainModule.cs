using MyMessenger.Domain.Shared;
using Volo.Abp.Modularity;

namespace MyMessenger.Domain
{
    [DependsOn(
        typeof(DomainSharedModule)
        )]
    public class DomainModule : AbpModule
    {
    }
}
