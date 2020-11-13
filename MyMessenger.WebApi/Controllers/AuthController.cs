using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyMessenger.Application.Contracts.ControllerRequests.AuthController;
using MyMessenger.Application.Services.Users;
using MyMessenger.WebApi.Controllers.Abstraction;
using System.Threading.Tasks;

namespace MyMessenger.WebApi.Controllers
{
    public class AuthController : BaseController
    {
        private readonly AuthService authService;

        public AuthController(AuthService authService)
        {
            this.authService = authService;
        }

        [AllowAnonymous]
        [HttpPost("api/auth/authenticate")]
        public async Task<AuthOutput> AuthenticateAsync([FromBody] AuthInput model)
        {
            var res = await authService.AuthenticateAsync(model);
            return res;
        }
    }
}
