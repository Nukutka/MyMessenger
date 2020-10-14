using Volo.Abp;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities;

namespace MyMessenger.Core.Services
{
    public class ExceptionManager : ISingletonDependency
    {
        public void Friendly(string text = "")
        {
            throw new UserFriendlyException(text);
        }

        public void NotFound(string text = "")
        {
            throw new EntityNotFoundException(text);
        }
    }
}
