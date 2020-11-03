using Volo.Abp.DependencyInjection;

namespace MyMessenger.Core.Services.Abstraction
{
    public interface IExceptionManager
    {
        void Friendly(string text = "");
        void EntityNotFound(string text = null);
        void NullArgument(string name);
        void EntityForbiddenEdit(string text = null);
        void UnsuccessfulAuthorize(string text = null);
    }
}
