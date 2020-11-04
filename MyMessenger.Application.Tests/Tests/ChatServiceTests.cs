using MyMessenger.Application.Services.Messaging;
using Shouldly;
using System;
using System.Threading.Tasks;
using Xunit;

namespace MyMessenger.Application.Tests.Tests
{
    public class ChatServiceTests : ApplicationTestsBase
    {
        private readonly ChatService chatService;

        public ChatServiceTests()
        {
            chatService = GetRequiredService<ChatService>();
        }

        [Fact]
        public async Task Get_Chat_Test()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                var user = await chatService.GetChatAsync(new Guid("39f8a6a9-e670-d61c-38e5-58d5f9d2df64"));

                user.ShouldNotBeNull();
            });
        }
    }
}
