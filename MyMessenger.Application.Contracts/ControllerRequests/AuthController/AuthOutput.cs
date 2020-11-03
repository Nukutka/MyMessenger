using MyMessenger.Application.Contracts.DTOs.Users;

namespace MyMessenger.Application.Contracts.ControllerRequests.AuthController
{
    public class AuthOutput
    {
        public AuthOutput(UserDtoOutput user, string token)
        {
            User = user;
            Token = token;
        }

        public UserDtoOutput User { get; set; }
        public string Token { get; set; }
    }
}
