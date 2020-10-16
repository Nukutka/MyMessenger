using MyMessenger.Security.Hash;
using MyMessenger.Security.Hash.Abstraction;

namespace MyMessenger.EntityFramework.Seeds.Abstraction
{
    public static class BaseSeed
    {
        public static IHashFunction hashFunction => new StreebogProvider();
    }
}
