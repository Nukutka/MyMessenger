using Microsoft.EntityFrameworkCore;
using MyMessenger.Application.Services.Abstraction;
using MyMessenger.Core.Factories;
using MyMessenger.Domain.Entities.AssociativeEntities;
using MyMessenger.Domain.Entities.Messaging;
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
        private readonly IRepository<UserChatAssociation> userChatAssociationRepository;
        private readonly MessagingFactory messagingFactory;

        public ChatService(IRepository<Chat> chatRepository, MessagingFactory messagingFactory)
        {
            this.chatRepository = chatRepository;
            this.messagingFactory = messagingFactory;
        }

        public IQueryable<Chat> GetChatsQuery()
        {
            return chatRepository.AsQueryable();
        }

        public async Task<List<Chat>> GetUserChatsAsync(Guid userId)
        {
            var chatIds = await userChatAssociationRepository
                .Where(uc => uc.UserId == userId)
                .Select(u => u.ChatId)
                .ToListAsync();

            var chats = await chatRepository
                .Where(c => chatIds.Contains(c.Id))
                .ToListAsync();

            return chats;
        }

        public async Task<Chat> GetChatAsync(Guid id)
        {
            var chat = await chatRepository.FirstOrDefaultAsync(c => c.Id == id);

            if (chat == null)
            {
                ExceptionManager.NotFound();
            }

            return chat;
        }

        public async Task<Chat> InsertChatAsync(Chat inputChat)
        {
            var chat = messagingFactory.CreateChat(inputChat.Name);
            await chatRepository.InsertAsync(chat);

            return chat;
        }

        public async Task<Chat> UpdateChatAsync(Guid id, Chat inputChat)
        {
            var chatExists = await chatRepository.AnyAsync(c => c.Id == id);
            Chat chat = null;

            if (chatExists)
            {
                chat = messagingFactory.CreateChat(id, inputChat.Name);
                await chatRepository.UpdateAsync(chat);
            }
            else
            {
                ExceptionManager.NotFound();
            }

            return chat;
        }

        public async Task DeleteChatAsync(Guid id)
        {
            var chatExists = await chatRepository.AnyAsync(c => c.Id == id);
            await chatRepository.DeleteAsync(c => c.Id == id);
        }
    }
}
