using Microsoft.EntityFrameworkCore;
using MyMessenger.Application.Services.Abstraction;
using MyMessenger.Core.Factories;
using MyMessenger.Domain.Entities.Messaging;
using MyMessenger.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace MyMessenger.Application.Services.Messaging
{
    public class ChatService : BaseService
    {
        private readonly IRepository<Chat> chatRepository;
        private readonly MessagingFactory messagingFactory;
        private readonly UserChatAssociationsService userChatAssociationsService;

        public ChatService(
            IRepository<Chat> chatRepository,
            UserChatAssociationsService userChatAssociationsService,
            MessagingFactory messagingFactory)
        {
            this.chatRepository = chatRepository;
            this.userChatAssociationsService = userChatAssociationsService;
            this.messagingFactory = messagingFactory;
        }

        public IQueryable<Chat> GetChatsQuery()
        {
            return chatRepository.AsQueryable();
        }

        public async Task<List<Chat>> GetUserChatsAsync(Guid userId)
        {
            var chats = await userChatAssociationsService.GetUserChatsAsync(userId);

            return chats;
        }

        public async Task<List<User>> GetChatUsersAsync(Guid chatId)
        {
            var users = await userChatAssociationsService.GetChatUsersAsync(chatId);

            return users;
        }

        public async Task<Chat> GetChatAsync(Guid id)
        {
            var chat = await chatRepository.FirstOrDefaultAsync(c => c.Id == id);

            if (chat == null) ExceptionManager.NotFound();

            return chat;
        }

        public async Task<Chat> InsertChatAsync(Chat inputChat, List<Guid> userIds)
        {
            var chat = messagingFactory.CreateChat(inputChat.Name);
            await chatRepository.InsertAsync(chat);

            await userChatAssociationsService.InsertAssociationsAsync(chat.Id, userIds);

            return chat;
        }

        public async Task<Chat> UpdateChatAsync(Guid id, Chat inputChat, List<Guid> userIds = null)
        {
            await CheckExistsEntity<Chat>(id);
            
            var chat = messagingFactory.CreateChat(id, inputChat.Name);
            await chatRepository.UpdateAsync(chat);

            if (userIds != null)
                await userChatAssociationsService.UpdateAssociationsAsync(id, userIds);

            return chat;
        }

        public async Task DeleteChatAsync(Guid id)
        {
            await CheckExistsEntity<Chat>(id);

            await chatRepository.DeleteAsync(c => c.Id == id);
            await userChatAssociationsService.DeleteAssociationsByChatAsync(id);
        }
    }
}
