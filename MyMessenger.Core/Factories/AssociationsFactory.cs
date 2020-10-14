using MyMessenger.Core.Factories.Abstraction;
using MyMessenger.Domain.Entities.AssociativeEntities;

namespace MyMessenger.Core.Factories
{
    /// <summary>
    /// For "many to many" relations
    /// </summary>
    public class AssociationsFactory : BaseFactory
    {
        public UserChatAssociation CreateUserChatAssociation(int userId, int chatId)
        {
            return new UserChatAssociation(guidGenerator.Create())
            {
                UserId = userId,
                ChatId = chatId
            };
        }
    }
}
