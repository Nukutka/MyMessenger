using MyMessenger.Core.Factories.Abstraction;
using MyMessenger.Core.Services;
using MyMessenger.Domain.Entities.Messaging;
using System;
using System.Collections.Generic;

namespace MyMessenger.Core.Factories
{
    public class MessagingFactory : BaseFactory
    {
        private readonly ArgumentChecker argumentChecker;

        public MessagingFactory(ArgumentChecker argumentChecker)
        {
            this.argumentChecker = argumentChecker;
        }

        public Attachment CreateAttachment(string fileName, byte[] data, string mimeType)
        {
            argumentChecker.CheckNullArgument(() => fileName);
            argumentChecker.CheckNullArgument(() => data);
            argumentChecker.CheckNullArgument(() => mimeType);

            return new Attachment(guidGenerator.Create())
            {
                FileName = fileName,
                Data = data,
                MimeType = mimeType,
            };
        }


        public Message CreateMessage(string body, Guid userId)
        {
            argumentChecker.CheckNullArgument(() => body);

            return new Message(guidGenerator.Create())
            {
                Body = body,
                UserId = userId,
                Attachments = new List<Attachment>()
            };
        }

        public Message CreateMessage(string body, Guid userId, List<Attachment> attachments)
        {
            argumentChecker.CheckNullArgument(() => body);

            return new Message(guidGenerator.Create())
            {
                Body = body,
                UserId = userId,
                Attachments = attachments
            };
        }

        public void AddAttachmentToMessage(Message message, Attachment attachment)
        {
            argumentChecker.CheckNullArgument(() => message);
            argumentChecker.CheckNullArgument(() => attachment);

            message.Attachments.Add(attachment);
        }

        public Chat CreateChat(string name)
        {
            argumentChecker.CheckNullArgument(() => name);

            return new Chat(guidGenerator.Create())
            {
                Name = name,
                Messages = new List<Message>()
            };
        }

        public Chat CreateChat(string name, List<Message> messages)
        {
            argumentChecker.CheckNullArgument(() => name);

            return new Chat(guidGenerator.Create())
            {
                Name = name,
                Messages = messages
            };
        }

        public void AddMessageToChat(Chat chat, Message message)
        {
            argumentChecker.CheckNullArgument(() => chat);
            argumentChecker.CheckNullArgument(() => message);

            chat.Messages.Add(message);
        }
    }
}
