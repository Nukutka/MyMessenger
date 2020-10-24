using MyMessenger.Core.Factories;
using MyMessenger.EntityFramework.Seeds.Utils;
using MyMessenger.Security.Hash;
using MyMessenger.Security.Hash.Abstraction;
using Volo.Abp.Guids;

namespace MyMessenger.EntityFramework.Seeds.Abstraction
{
    public static class BaseSeed
    {
        public static IHashFunction HashFunction => new StreebogProvider();
        public static IGuidGenerator GuidGenerator => SeedGuidGenerator.Instance;
    }
}
