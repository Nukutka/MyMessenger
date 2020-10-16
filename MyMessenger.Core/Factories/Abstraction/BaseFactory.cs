using MyMessenger.Core.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;

namespace MyMessenger.Core.Factories.Abstraction
{
    public abstract class BaseFactory : ISingletonDependency
    {
        protected readonly ArgumentChecker argumentChecker;
        protected readonly IGuidGenerator guidGenerator;

        public BaseFactory(ArgumentChecker argumentChecker)
        {
            guidGenerator = SimpleGuidGenerator.Instance;
            this.argumentChecker = argumentChecker;
        }
    }
}
