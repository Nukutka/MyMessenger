using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMessenger.Application.Contracts.ControllerRequests.ChatController;
using MyMessenger.Application.Contracts.DTOs.Messaging;
using MyMessenger.Application.Contracts.DTOs.Users;
using MyMessenger.Application.Services.Messaging;
using MyMessenger.Domain.Entities.Messaging;
using MyMessenger.Domain.Entities.Users;
using MyMessenger.Domain.Shared.Constants;
using MyMessenger.WebApi.Controllers.Abstraction;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyMessenger.WebApi.Controllers
{
    public class ChatController : BaseMapController<Chat, ChatDtoInput, ChatDtoOutput>
    {
        private readonly ChatService chatService;

        public ChatController(ChatService chatService)
        {
            this.chatService = chatService;
        }

        [Authorize(Roles = UserRoles.All)]
        [HttpGet("api/chats")]
        public async Task<List<ChatDtoOutput>> GetChatsAsync()
        {
            var chats = await chatService.GetChatsQuery()
                .ToListAsync();

            return MapEntityToDto(chats);
        }

        [Authorize(Roles = UserRoles.All)]
        [HttpGet("api/chats/user/{userId}")]
        public async Task<List<ChatDtoOutput>> GetUserChatsAsync(Guid userId)
        {
            var chats = await chatService.GetUserChatsAsync(userId);

            return MapEntityToDto(chats);
        }

        [Authorize(Roles = UserRoles.All)]
        [HttpGet("api/chats/{chatId}/users")]
        public async Task<List<UserDtoOutput>> GetChatUsersAsync(Guid chatId)
        {
            var users = await chatService.GetChatUsersAsync(chatId);

            return ObjectMapper.Map<List<User>, List<UserDtoOutput>>(users);
        }

        [Authorize(Roles = UserRoles.All)]
        [HttpGet("api/chats/{id}")]
        public async Task<ChatDtoOutput> GetChatAsync(Guid id)
        {
            var chat = await chatService.GetChatAsync(id);

            return MapEntityToDto(chat);
        }

        [Authorize(Roles = UserRoles.All)]
        [HttpPost("api/chats")]
        public async Task<ChatDtoOutput> InsertChatAsync([FromBody] InsertChatInput model)
        {
            var inputChat = MapDtoToEntity(model.Chat);
            var chat = await chatService.InsertChatAsync(inputChat, model.UserIds);

            return MapEntityToDto(chat);
        }

        [Authorize(Roles = UserRoles.All)]
        [HttpPut("api/chats/{id}")]
        public async Task<ChatDtoOutput> UpdateChatAsync(Guid id, [FromBody] UpdateChatInput model)
        {
            var inputChat = MapDtoToEntity(model.Chat);
            var chat = await chatService.UpdateChatAsync(id, inputChat, model.UserIds);

            return MapEntityToDto(chat);
        }

        [Authorize(Roles = UserRoles.All)]
        [HttpDelete("api/chats/{id}")]
        public async Task DeleteChatAsync(Guid id)
        {
            await chatService.DeleteChatAsync(id);
            Response.StatusCode = 204;
        }
    }
}
