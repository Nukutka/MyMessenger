using MyMessenger.Domain.Shared.Interfaces;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyMessenger.Domain.Entities.Messaging
{
    public class Message : AuditedEntity<Guid>, IOwnedEntity
    {
        public string Body { get; set; }
        public List<Attachment> Attachments { get; set; }
        public Guid UserId { get; set; }
        public Guid ChatId { get; set; }

        protected Message()
        {

        }

        public Message(Guid id)
            : base (id)
        {

        }
    }
}
