using Microsoft.EntityFrameworkCore;
using MyMessenger.Application.Services.Abstraction;
using MyMessenger.Core.Factories;
using MyMessenger.Domain.Entities.AssociativeEntities;
using MyMessenger.Domain.Entities.Messaging;
using MyMessenger.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace MyMessenger.Application.Services.Messaging
{
    public class UserChatAssociationsService : BaseService
    {
        private readonly IRepository<UserChatAssociation> userChatAssociationRepository;
        private readonly IRepository<User> userRepository;
        private readonly IRepository<Chat> chatRepository;
        private readonly AssociationsFactory associationsFactory;

        public UserChatAssociationsService(
            IRepository<UserChatAssociation> userChatAssociationRepository,
            IRepository<User> userRepository,
            IRepository<Chat> chatRepository,
            AssociationsFactory associationsFactory)
        {
            this.userChatAssociationRepository = userChatAssociationRepository;
            this.userRepository = userRepository;
            this.chatRepository = chatRepository;
            this.associationsFactory = associationsFactory;
        }

        public async Task<List<User>> GetChatUsersAsync(Guid chatId)
        {
            var userIds = await userChatAssociationRepository
                .Where(uc => uc.ChatId == chatId)
                .Select(uc => uc.UserId)
                .ToListAsync();

            var users = await userRepository
                .Where(c => userIds.Contains(c.Id))
                .ToListAsync();

            return users;
        }

        public async Task<List<Chat>> GetUserChatsAsync(Guid userId)
        {
            var chatIds = await userChatAssociationRepository
                .Where(uc => uc.UserId == userId)
                .Select(uc => uc.ChatId)
                .ToListAsync();

            var chats = await chatRepository
                .Where(c => chatIds.Contains(c.Id))
                .ToListAsync();

            return chats;
        }

        public async Task InsertAssociationsAsync(Guid chatId, IEnumerable<Guid> userIds)
        {
            var userChatAssociations = new List<UserChatAssociation>();

            foreach (var userId in userIds)
            {
                var userChatAssociation = associationsFactory.CreateUserChatAssociation(userId, chatId);
                userChatAssociations.Add(userChatAssociation);
            }

            await BulkInsertAsync(userChatAssociations);
        }

        // TODO: auto cascade delete
        public async Task DeleteAssociationsByChatAsync(Guid chatId)
        {
            var userChatAssociations = await userChatAssociationRepository
              .Where(uc => uc.ChatId == chatId)
              .ToListAsync();

            await BulkDeleteAsync(userChatAssociations);
        }

        // TODO: auto cascade delete
        public async Task DeleteAssociationsByUserAsync(Guid userId)
        {
            var userChatAssociations = await userChatAssociationRepository
              .Where(uc => uc.UserId == userId)
              .ToListAsync();

            await BulkDeleteAsync(userChatAssociations);
        }

        public async Task UpdateAssociationsAsync(Guid chatId, List<Guid> userIds)
        {
            await DeleteAssociationsByChatAsync(chatId);
            await InsertAssociationsAsync(chatId, userIds);
        }
    }
}
