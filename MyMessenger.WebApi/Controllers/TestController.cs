using Microsoft.AspNetCore.Mvc;
using MyMessenger.Application.DTOs.Users;
using MyMessenger.Application.Services;
using MyMessenger.Domain.Entities.Users;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace MyMessenger.WebApi.Controllers
{
    public class TestController : AbpController
    {
        private readonly TestService testService;

        public TestController(TestService testService)
        {
            this.testService = testService;
        }

        [HttpGet("api/test/users")]
        public async Task<List<UserDtoOutput>> GetUsersAsync()
        {
            var users = await testService.GetUsersAsync();
            return ObjectMapper.Map<List<User>, List<UserDtoOutput>>(users);
        }


        [HttpPost("api/test/users")]
        public async Task<UserDtoOutput> InsertUserAsync([FromBody] UserDtoInput model)
        {
            var inputUser = ObjectMapper.Map<UserDtoInput, User>(model);
            var user = await testService.InsertUser(inputUser);
            return ObjectMapper.Map<User, UserDtoOutput>(user);
        }
    }
}
