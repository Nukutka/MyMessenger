using MyMessenger.Core.Services.Abstraction;
using Volo.Abp.Application.Services;

namespace MyMessenger.Application.Services.Abstraction
{
    public abstract class BaseService : ApplicationService
    {
        private IArgumentChecker argumentChecker;
        protected IArgumentChecker ArgumentChecker => LazyGetRequiredService(ref argumentChecker);

        private IExceptionManager exceptionManager;
        protected IExceptionManager ExceptionManager => LazyGetRequiredService(ref exceptionManager);
    }
}
