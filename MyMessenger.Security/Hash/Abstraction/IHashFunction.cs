namespace MyMessenger.Security.Hash.Abstraction
{
    public interface IHashFunction
    {
        string GenerateHashCode(string input);
        string GenerateHashCode(byte[] input);
    }
}
