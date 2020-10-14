using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyMessenger.Domain.Entities.Messaging
{
    public class Message : AuditedAggregateRoot<Guid>
    {
        public string Body { get; set; }
        public List<Attachment> Attachments { get; set; }
        public int UserId { get; set; }
        public int ChatId { get; set; }
    }
}
