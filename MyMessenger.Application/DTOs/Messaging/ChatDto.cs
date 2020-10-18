using AutoMapper;
using MyMessenger.Domain.Entities.Messaging;
using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace MyMessenger.Application.DTOs.Messaging
{
    [AutoMap(typeof(Chat))]
    public class ChatDtoInput
    {
        public string Name { get; set; }
    }

    [AutoMap(typeof(Chat))]
    public class ChatDtoOutput : EntityDto<Guid>
    {
        public string Name { get; set; }
        public List<MessageDtoOutput> Messages { get; set; }
    }
}
