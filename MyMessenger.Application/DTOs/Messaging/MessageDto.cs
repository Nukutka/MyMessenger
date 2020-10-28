using AutoMapper;
using MyMessenger.Application.DTOs.Abstraction;
using MyMessenger.Domain.Entities.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyMessenger.Application.DTOs.Messaging
{
    [AutoMap(typeof(Message), ReverseMap = true)]
    public class MessageDtoInput : BaseDtoInput
    {
        [Required]
        public string Body { get; set; }

        [Required]
        public Guid ChatId { get; set; }

        public List<AttachmentDtoInput> Attachments { get; set; }
    }

    [AutoMap(typeof(Message))]
    public class MessageDtoOutput : BaseDtoOutput
    {
        public string Body { get; set; }
        public Guid ChatId { get; set; }
        public List<AttachmentDtoOutput> Attachments { get; set; }
    }
}
