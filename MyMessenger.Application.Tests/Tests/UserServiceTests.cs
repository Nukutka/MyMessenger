using MyMessenger.Application.Services.Users;
using Shouldly;
using System;
using System.Threading.Tasks;
using Xunit;

namespace MyMessenger.Application.Tests.Tests
{
    public class UserServiceTests : ApplicationTestsBase
    {
        private readonly UserService userService;

        public UserServiceTests()
        {
            userService = GetRequiredService<UserService>();
        }

        [Fact]
        public async Task Get_User_Test()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                var user = await userService.GetUserAsync(new Guid("00000000-0000-0000-0000-000000000001"));

                user.ShouldNotBeNull();
            });
        }
    }
}
