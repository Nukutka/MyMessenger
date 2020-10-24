using MyMessenger.Core.Services.Abstraction;
using Volo.Abp.Domain.Services;

namespace MyMessenger.Core.Factories.Abstraction
{
    public abstract class BaseFactory : DomainService
    {
        private IArgumentChecker argumentChecker;
        protected IArgumentChecker ArgumentChecker => LazyGetRequiredService(ref argumentChecker);
    }
}
