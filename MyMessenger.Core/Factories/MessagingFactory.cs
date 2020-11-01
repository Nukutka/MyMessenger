using MyMessenger.Core.Factories.Abstraction;
using MyMessenger.Domain.Entities.Messaging;
using System;
using System.Collections.Generic;

namespace MyMessenger.Core.Factories
{
    public class MessagingFactory : BaseFactory
    {
        public Attachment CreateAttachment(string fileName, byte[] data, string mimeType)
        {
            ArgumentChecker.CheckNullArgument(() => fileName);
            ArgumentChecker.CheckNullArgument(() => data);
            ArgumentChecker.CheckNullArgument(() => mimeType);

            return new Attachment(GuidGenerator.Create())
            {
                FileName = fileName,
                Data = data,
                MimeType = mimeType,
            };
        }

        public Message CreateMessage(string body, Guid userId, Guid chatId)
        {
            ArgumentChecker.CheckNullArgument(() => body);

            return new Message(GuidGenerator.Create())
            {
                Body = body,
                UserId = userId,
                ChatId = chatId,
                Attachments = new List<Attachment>()
            };
        }

        public Message CreateMessage(Guid id, string body, Guid userId, Guid chatId)
        {
            ArgumentChecker.CheckNullArgument(() => body);

            return new Message(id)
            {
                Body = body,
                UserId = userId,
                ChatId = chatId,
                Attachments = new List<Attachment>()
            };
        }

        public void AddAttachmentToMessage(Message message, Attachment attachment)
        {
            ArgumentChecker.CheckNullArgument(() => message);
            ArgumentChecker.CheckNullArgument(() => attachment);

            message.Attachments.Add(attachment);
        }

        public Chat CreateChat(string name)
        {
            ArgumentChecker.CheckNullArgument(() => name);

            return new Chat(GuidGenerator.Create())
            {
                Name = name,
                Messages = new List<Message>()
            };
        }

        public Chat CreateChat(Guid id, string name)
        {
            ArgumentChecker.CheckNullArgument(() => name);

            return new Chat(id)
            {
                Name = name,
                Messages = new List<Message>()
            };
        }

        public void AddMessageToChat(Chat chat, Message message)
        {
            ArgumentChecker.CheckNullArgument(() => chat);
            ArgumentChecker.CheckNullArgument(() => message);

            chat.Messages.Add(message);
        }
    }
}
