using AutoMapper;
using MyMessenger.Domain.Entities.Users;
using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace MyMessenger.Application.DTOs.Users
{
    [AutoMap(typeof(User))]
    public class UserDtoInput
    {
        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        public UserInfoDtoInput UserInfo { get; set; }
    }

    [AutoMap(typeof(User))]
    public class UserDtoOutput : EntityDto<Guid>
    {
        public string Login { get; set; }
        public UserInfoDtoOutput UserInfo { get; set; }
    }
}
