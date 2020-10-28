using MyMessenger.Core.Services.Abstraction;
using MyMessenger.Domain.Shared.Constants;
using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace MyMessenger.Core.Services
{
    public class ExceptionManager : IExceptionManager
    {
        public void Friendly(string text = "")
        {
            throw new UserFriendlyException(text);
        }

        public void NotFound(string text = "")
        {
            if (text.IsNullOrEmpty())
            {
                text = ExceptionMessages.NotFound;
            }

            throw new EntityNotFoundException(text);
        }

        public void NullArgument(string name)
        {
            throw new UserFriendlyException($"{name}: {ExceptionMessages.NullArgument}");
        }
    }
}
