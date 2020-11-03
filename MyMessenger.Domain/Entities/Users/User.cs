using MyMessenger.Domain.Shared.Enums.Users;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyMessenger.Domain.Entities.Users
{
    public class User : AuditedEntity<Guid>
    {
        public string Login { get; set; }
        public string HashPassword { get; set; }
        public string Role { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public UserActiveStatuses ActiveStatus { get; set; }

        protected User()
        {

        }

        public User(Guid id)
            : base(id)
        {

        }
    }
}
