using MyMessenger.Security.Hash.Abstraction;
using SharpHash.Base;
using System.Text;

namespace MyMessenger.Security.Hash
{
    public class StreebogProvider : IHashFunction
    {
        public string GenerateHashCode(string input)
        {
            var provider = HashFactory.Crypto.CreateGOST3411_2012_512();
            var hash = provider.ComputeString(input, Encoding.UTF8);
            return hash.ToString();
        }

        public string GenerateHashCode(byte[] input)
        {
            var provider = HashFactory.Crypto.CreateGOST3411_2012_512();
            var hash = provider.ComputeBytes(input);
            return hash.ToString();
        }
    }
}
