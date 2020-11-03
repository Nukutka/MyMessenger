using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMessenger.Application.Contracts.DTOs.Messaging;
using MyMessenger.Application.Services;
using MyMessenger.Application.Services.Messaging;
using MyMessenger.Domain.Entities.Messaging;
using MyMessenger.Domain.Shared.Constants;
using MyMessenger.WebApi.Controllers.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMessenger.WebApi.Controllers
{
    public class MessageController : BaseMapController<Message, MessageDtoInput, MessageDtoOutput>
    {
        private readonly MessageService messageService;
        private readonly CheckOwnerService checkOwnerService;

        public MessageController(MessageService messageService, CheckOwnerService checkOwnerService)
        {
            this.messageService = messageService;
            this.checkOwnerService = checkOwnerService;
        }

        [Authorize(Roles = UserRoles.All)]
        [HttpGet("api/messages")]
        public async Task<List<MessageDtoOutput>> GetMessagesAsync()
        {
            var messages = await messageService.GetMessagesQuery()
                .ToListAsync();

            return MapEntityToDto(messages);
        }

        [Authorize(Roles = UserRoles.All)]
        [HttpGet("api/messages/chat/{chatId}")]
        public async Task<List<MessageDtoOutput>> GetMessagesAsync(Guid chatId)
        {
            var messages = await messageService.GetChatMessagesAsync(chatId, true);

            return MapEntityToDto(messages);
        }

        [Authorize(Roles = UserRoles.All)]
        [HttpGet("api/messages/{id}")]
        public async Task<MessageDtoOutput> GetMessageAsync(Guid id)
        {
            var message = await messageService.GetMessageAsync(id);

            return MapEntityToDto(message);
        }

        [Authorize(Roles = UserRoles.All)]
        [HttpPost("api/messages")]
        public async Task<MessageDtoOutput> InsertMessageAsync([FromBody] MessageDtoInput model)
        {
            var inputMessage = MapDtoToEntity(model);
            var userId = GetUserId();

            var message = await messageService.InsertMessageAsync(inputMessage, userId);

            return MapEntityToDto(message);
        }

        [Authorize(Roles = UserRoles.All)]
        [HttpPut("api/messages/{id}")]
        public async Task<MessageDtoOutput> UpdateMessageAsync(Guid id, [FromBody] MessageDtoInput model)
        {
            var inputMessage = MapDtoToEntity(model);
            var userId = GetUserId();

            await checkOwnerService.CheckOwnerAndThrowAsync<Message>(id, userId);
            var message = await messageService.UpdateMessageAsync(id, inputMessage, userId);

            return MapEntityToDto(message);
        }

        [Authorize(Roles = UserRoles.All)]
        [HttpDelete("api/messages/{id}")]
        public async Task DeleteMessageAync(Guid id)
        {
            var userId = GetUserId();

            await checkOwnerService.CheckOwnerAndThrowAsync<Message>(id, userId);
            await messageService.DeleteMessageAsync(id, userId);

            Response.StatusCode = 204;
        }
    }
}
