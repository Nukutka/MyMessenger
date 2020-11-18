using MyMessenger.Application.Contracts.ControllerRequests.AuthController;
using MyMessenger.Application.Services.Users;
using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace MyMessenger.Application.Tests.Tests
{
    public class AuthServiceTests : ApplicationTestsBase
    {
        private readonly AuthService authService;

        public AuthServiceTests()
        {
            authService = GetRequiredService<AuthService>();
        }

        [Fact]
        public async Task Auth_Test()
        {
            var authInput = new AuthInput { Email = "test@test.com", Password = "qwerty123456" };

            await WithUnitOfWorkAsync(async () =>
            {
                var res = await authService.AuthenticateAsync(authInput);

                res?.Token.ShouldNotBeNull();
            });
        }
    }
}
