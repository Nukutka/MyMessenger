using MyMessenger.Domain.Entities.Messaging;
using MyMessenger.Domain.Entities.Users;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyMessenger.Domain.Entities.AssociativeEntities
{
    public class UserChatAssociation : AuditedEntity<Guid>
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Chat Chat { get; set; }
        public int ChatId { get; set; }
    }
}
