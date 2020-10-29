using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMessenger.Application.Contracts.DTOs.Messaging;
using MyMessenger.Application.Services.Messaging;
using MyMessenger.Domain.Entities.Messaging;
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

        [HttpGet("api/chats")]
        public async Task<List<ChatDtoOutput>> GetChatsAsync()
        {
            var chats = await chatService.GetChatsQuery()
                .ToListAsync();

            return MapEntityToDto(chats);
        }

        [HttpGet("api/chats/user/{userId}")]
        public async Task<List<ChatDtoOutput>> GetUserChatsAsync(Guid userId)
        {
            var chats = await chatService.GetUserChatsAsync(userId);

            return MapEntityToDto(chats);
        }

        [HttpGet("api/chats/{id}")]
        public async Task<ChatDtoOutput> GetChatAsync(Guid id)
        {
            var chat = await chatService.GetChatAsync(id);

            return MapEntityToDto(chat);
        }

        [HttpPost("api/chats")]
        public async Task<ChatDtoOutput> InsertChatAsync([FromBody] ChatDtoInput model)
        {
            var inputChat = MapDtoToEntity(model);
            var chat = await chatService.InsertChatAsync(inputChat);

            return MapEntityToDto(chat);
        }

        [HttpPut("api/chats/{id}")]
        public async Task<ChatDtoOutput> UpdateChatAsync(Guid id, [FromBody] ChatDtoInput model)
        {
            var inputChat = MapDtoToEntity(model);
            var chat = await chatService.UpdateChatAsync(id, inputChat);

            return MapEntityToDto(chat);
        }

        [HttpDelete("api/chats/{id}")]
        public async Task DeleteChatAsync(Guid id)
        {
            await chatService.DeleteChatAsync(id);
            Response.StatusCode = 204;
        }
    }
}
