using Volo.Abp.DependencyInjection;

namespace MyMessenger.Core.Services.Abstraction
{
    public interface IExceptionManager
    {
        void Friendly(string text = "");
        void NotFound(string text = "");
        void NullArgument(string name);
    }
}
