using MyMessenger.Domain.Entities.Messaging;
using MyMessenger.Domain.Entities.Users;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyMessenger.Domain.Entities.AssociativeEntities
{
    public class UserChatAssociation : AuditedEntity<Guid>
    {
        public User User { get; set; }
        public Guid UserId { get; set; }
        public Chat Chat { get; set; }
        public Guid ChatId { get; set; }

        protected UserChatAssociation()
        {

        }

        public UserChatAssociation(Guid id)
            : base(id)
        {

        }
    }
}
