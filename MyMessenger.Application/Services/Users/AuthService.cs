using MyMessenger.Application.Contracts.ControllerRequests.AuthController;
using MyMessenger.Application.Contracts.DTOs.Users;
using MyMessenger.Application.Services.Abstraction;
using MyMessenger.Domain.Entities.Users;
using MyMessenger.Security.Hash.Abstraction;
using System.Threading.Tasks;

namespace MyMessenger.Application.Services.Users
{
    public class AuthService : BaseService
    {
        private readonly UserService userService;
        private readonly IJwtGenerator jwtGenerator;
        private readonly IHashFunction hashFunction;

        public AuthService(UserService userService, IJwtGenerator jwtGenerator, IHashFunction hashFunction)
        {
            this.userService = userService;
            this.jwtGenerator = jwtGenerator;
            this.hashFunction = hashFunction;
        }

        public async Task<AuthOutput> AuthenticateAsync(AuthInput model)
        {
            var user = await userService.GetUserByEmailAsync(model.Email);
            var hashPassword = hashFunction.GenerateHashCode(model.Password);

            if (user == null || hashPassword != user.HashPassword)
                ExceptionManager.UnsuccessfulAuthorize();

            var token = jwtGenerator.GetJwtToken(user.Id, user.Role);

            var res = new AuthOutput(ObjectMapper.Map<User, UserDtoOutput>(user), token);
            return res;
        }

        // TODO: register
    }
}
