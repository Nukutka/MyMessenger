﻿using AutoMapper;
using MyMessenger.Application.DTOs.Abstraction;
using MyMessenger.Domain.Entities.Messaging;
using System.Collections.Generic;

namespace MyMessenger.Application.DTOs.Messaging
{
    [AutoMap(typeof(Chat), ReverseMap = true)]
    public class ChatDtoInput : BaseDtoInput
    {
        public string Name { get; set; }
    }

    [AutoMap(typeof(Chat))]
    public class ChatDtoOutput : BaseDtoOutput
    {
        public string Name { get; set; }
        public List<MessageDtoOutput> Messages { get; set; }
    }
}
