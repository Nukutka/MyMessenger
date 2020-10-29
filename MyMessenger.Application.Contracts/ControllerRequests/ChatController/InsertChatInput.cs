using MyMessenger.Application.Contracts.DTOs.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyMessenger.Application.Contracts.ControllerRequests.ChatController
{
    public class InsertChatInput
    {
        [Required]
        public ChatDtoInput Chat { get; set; }

        [Required]
        public List<Guid> UserIds { get; set; }
    }
}
