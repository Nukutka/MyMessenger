using AutoMapper;
using MyMessenger.Application.Contracts.DTOs.Abstraction;
using MyMessenger.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace MyMessenger.Application.Contracts.DTOs.Users
{
    [AutoMap(typeof(User), ReverseMap = true)]
    public class UserDtoInput : BaseDtoInput
    {
        [Required]
        public string Login { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public string Email { get; set; }
    }

    [AutoMap(typeof(User))]
    public class UserDtoOutput : BaseDtoOutput
    {
        public string Login { get; set; }
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }
    }
}
