using AutoMapper;
using MyMessenger.Application.Contracts.DTOs.Abstraction;
using MyMessenger.Domain.Entities.Users;
using MyMessenger.Domain.Shared.Enums.Users;
using System.ComponentModel.DataAnnotations;

namespace MyMessenger.Application.Contracts.DTOs.Users
{
    [AutoMap(typeof(UserInfo), ReverseMap = true)]
    public class UserInfoDtoInput : BaseDtoInput
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Email { get; set; }
    }

    [AutoMap(typeof(UserInfo))]
    public class UserInfoDtoOutput : BaseDtoOutput
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public UserActiveStatuses ActiveStatus { get; set; }
    }
}
