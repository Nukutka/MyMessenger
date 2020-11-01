﻿using Microsoft.EntityFrameworkCore;
using MyMessenger.Application.Services.Abstraction;
using MyMessenger.Core.Factories;
using MyMessenger.Domain.Entities.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace MyMessenger.Application.Services.Messaging
{
    public class MessageService : BaseService
    {
        private readonly IRepository<Message> messageRepository;
        private readonly MessagingFactory messagingFactory;
        private readonly UserChatAssociationsService userChatAssociationsService;

        public MessageService(
            IRepository<Message> messageRepository,
            MessagingFactory messagingFactory,
            UserChatAssociationsService userChatAssociationsService)
        {
            this.messageRepository = messageRepository;
            this.messagingFactory = messagingFactory;
            this.userChatAssociationsService = userChatAssociationsService;
        }

        public IQueryable<Message> GetMessagesQuery()
        {
            return messageRepository.AsQueryable();
        }

        public async Task<List<Message>> GetChatMessagesAsync(Guid chatId, bool orderByDate = false)
        {
            var messages = messageRepository.Where(m => m.ChatId == chatId);

            if (orderByDate)
            {
                messages = messages.OrderBy(m => m.CreationTime);
            }

            return await messages.ToListAsync();
        }

        public async Task<Message> GetMessageAsync(Guid id)
        {
            var message = await messageRepository.GetAsync(m => m.Id == id);

            if (message == null) ExceptionManager.EntityNotFound();

            return message;
        }

        public async Task<Message> InsertMessageAsync(Message inputMessage, Guid userId)
        {
            var check = await userChatAssociationsService.CheckUserInChatAsync(inputMessage.ChatId, userId);
            if (!check) ExceptionManager.Friendly("Chat not found");

            var message = messagingFactory.CreateMessage(inputMessage.Body, userId, inputMessage.ChatId);
            await messageRepository.InsertAsync(message);

            return message;
        }

        public async Task<Message> UpdateMessageAsync(Guid id, Message inputMessage, Guid userId)
        {
            var check = await userChatAssociationsService.CheckUserInChatAsync(inputMessage.ChatId, userId);
            if (!check) ExceptionManager.Friendly("Chat not found");
            
            var message = messagingFactory.CreateMessage(id, inputMessage.Body, userId, inputMessage.ChatId);
            await messageRepository.UpdateAsync(message);

            return message;
        }

        public async Task DeleteMessageAsync(Guid id, Guid userId)
        {
            await messageRepository.DeleteAsync(m => m.Id == id);
        }
    }
}
