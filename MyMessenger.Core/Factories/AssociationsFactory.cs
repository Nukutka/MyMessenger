using MyMessenger.Core.Factories.Abstraction;
using MyMessenger.Domain.Entities.AssociativeEntities;
using System;

namespace MyMessenger.Core.Factories
{
    /// <summary>
    /// For "many to many" relations
    /// </summary>
    public class AssociationsFactory : BaseFactory
    {
        public UserChatAssociation CreateUserChatAssociation(Guid userId, Guid chatId)
        {
            return new UserChatAssociation(GuidGenerator.Create())
            {
                UserId = userId,
                ChatId = chatId
            };
        }
    }
}
