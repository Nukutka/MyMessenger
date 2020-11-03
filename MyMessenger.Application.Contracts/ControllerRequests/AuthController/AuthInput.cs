using System.ComponentModel.DataAnnotations;

namespace MyMessenger.Application.Contracts.ControllerRequests.AuthController
{
    public class AuthInput
    {
        [Required]
        public string Login { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}
