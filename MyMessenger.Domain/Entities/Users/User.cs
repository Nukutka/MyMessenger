using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyMessenger.Domain.Entities.Users
{
    public class User : AuditedEntity<Guid>
    {
        public string Login { get; set; }
        public string HashPassword { get; set; }

        public UserInfo UserInfo { get; set; }

        protected User()
        {

        }

        public User(Guid id)
            : base(id)
        {

        }
    }
}
