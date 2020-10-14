using MyMessenger.Core.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;

namespace MyMessenger.Core.Factories.Abstraction
{
    public abstract class BaseFactory : ISingletonDependency
    {
        protected readonly IGuidGenerator guidGenerator;

        public BaseFactory()
        {
            guidGenerator = SimpleGuidGenerator.Instance;
        }
    }
}
