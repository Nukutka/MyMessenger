using AutoMapper;
using MyMessenger.Domain.Entities.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace MyMessenger.Application.DTOs.Messaging
{
    [AutoMap(typeof(Message))]
    public class MessageDtoInput
    {
        [Required]
        public string Body { get; set; }

        [Required]
        public Guid ChatId { get; set; }

        public List<AttachmentDtoInput> Attachments { get; set; }
    }

    [AutoMap(typeof(Message))]
    public class MessageDtoOutput : EntityDto<Guid>
    {
        public string Body { get; set; }
        public Guid ChatId { get; set; }
        public List<AttachmentDtoOutput> Attachments { get; set; }
    }
}
