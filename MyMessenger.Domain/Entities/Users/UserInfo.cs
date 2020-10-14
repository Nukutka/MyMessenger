using MyMessenger.Domain.Shared.Enums.Users;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyMessenger.Domain.Entities.Users
{
    public class UserInfo : AuditedEntity<Guid>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public Guid UserId { get; set; }

        public UserActiveStatuses ActiveStatus { get; set; }

        protected UserInfo()
        {

        }

        public UserInfo(Guid id)
            : base(id)
        {

        }
    }
}
