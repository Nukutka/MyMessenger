using MyMessenger.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyMessenger.Domain.Entities.Messaging
{
    public class Chat : AuditedEntity<Guid>
    {
        public string Name { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
