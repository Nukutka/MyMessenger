using System;

namespace MyMessenger.Security.Hash.Abstraction
{
    public interface IJwtGenerator
    {
        string GetJwtToken(Guid userId, string role);
    }
}
