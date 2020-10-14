using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyMessenger.Domain.Entities.Messaging
{
    public class Attachment : AuditedEntity<Guid>
    {
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public byte[] Data { get; set; } // or fs path
        public int MessageId { get; set; }
    }
}
