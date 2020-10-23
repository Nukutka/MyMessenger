using Microsoft.Extensions.DependencyInjection;
using MyMessenger.Core.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Services;
using Volo.Abp.Guids;

namespace MyMessenger.Core.Factories.Abstraction
{
    public abstract class BaseFactory : DomainService, ISingletonDependency
    {
        protected readonly ArgumentChecker argumentChecker;
        protected readonly IGuidGenerator guidGenerator;

        public BaseFactory()
        {
            this.argumentChecker = ServiceProvider.GetRequiredService<ArgumentChecker>();
            this.guidGenerator = SimpleGuidGenerator.Instance;
        }
    }
}
