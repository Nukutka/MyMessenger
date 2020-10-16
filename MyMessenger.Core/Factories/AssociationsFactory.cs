using MyMessenger.Core.Factories.Abstraction;
using MyMessenger.Core.Services;
using MyMessenger.Domain.Entities.AssociativeEntities;
using System;

namespace MyMessenger.Core.Factories
{
    /// <summary>
    /// For "many to many" relations
    /// </summary>
    public class AssociationsFactory : BaseFactory
    {
        public AssociationsFactory(ArgumentChecker argumentChecker)
            : base(argumentChecker)
        {

        }

        public UserChatAssociation CreateUserChatAssociation(Guid userId, Guid chatId)
        {
            return new UserChatAssociation(guidGenerator.Create())
            {
                UserId = userId,
                ChatId = chatId
            };
        }
    }
}
