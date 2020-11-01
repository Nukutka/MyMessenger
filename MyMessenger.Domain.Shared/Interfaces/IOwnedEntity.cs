using System;

namespace MyMessenger.Domain.Shared.Interfaces
{
    public interface IOwnedEntity 
    {
        Guid UserId { get; }
    }
}
