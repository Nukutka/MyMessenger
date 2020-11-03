using MyMessenger.Core.Services.Abstraction;
using MyMessenger.Domain.Shared.Constants;
using System;
using Volo.Abp;
using Volo.Abp.Authorization;
using Volo.Abp.Domain.Entities;

namespace MyMessenger.Core.Services
{
    public class ExceptionManager : IExceptionManager
    {
        public void Friendly(string text = "")
        {
            throw new UserFriendlyException(text);
        }

        public void EntityNotFound(string text = null)
        {
            if (text == null)
            {
                text = ExceptionMessages.EntityNotFound;
            }

            throw new EntityNotFoundException(text);
        }

        public void NullArgument(string name)
        {
            throw new UserFriendlyException($"{name}: {ExceptionMessages.NullArgument}");
        }

        public void EntityForbiddenEdit(string text = null)
        {
            if (text.IsNullOrEmpty())
            {
                text = ExceptionMessages.EntityForbiddenEdit;
            }

            // 404 status code, simulated "not found"
            throw new EntityNotFoundException(text);
        }

        public void UnsuccessfulAuthorize(string text = null)
        {
            if (text.IsNullOrEmpty())
            {
                text = ExceptionMessages.UnsuccessfulAuthorize;
            }

            throw new AbpAuthorizationException(text);
        }
    }
}
