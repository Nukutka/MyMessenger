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
        public string Password { get; set; }

        public UserInfoDtoInput UserInfo { get; set; }
    }

    [AutoMap(typeof(User))]
    public class UserDtoOutput : BaseDtoOutput
    {
        public string Login { get; set; }
        public UserInfoDtoOutput UserInfo { get; set; }
    }
}
