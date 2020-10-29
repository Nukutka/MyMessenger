using MyMessenger.Application.Contracts.DTOs.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyMessenger.Application.Contracts.ControllerRequests.ChatController
{
    public class UpdateChatInput
    {
        [Required]
        public ChatDtoInput Chat { get; set; }

        public List<Guid> UserIds { get; set; }
    }
}
