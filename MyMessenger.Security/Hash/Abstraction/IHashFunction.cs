using Volo.Abp.DependencyInjection;

namespace MyMessenger.Security.Hash.Abstraction
{
    public interface IHashFunction : ISingletonDependency
    {
        string GetHashCode(string input);
        string GetHashCode(byte[] input);
    }
}
