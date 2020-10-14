using MyMessenger.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyMessenger.Domain.Entities.Messaging
{
    public class Chat : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public List<Message> Messages { get; set; }

        protected Chat()
        {
                
        }

        public Chat(Guid id)
            : base(id)
        {

        }
    }
}
