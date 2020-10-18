using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace MyMessenger.Application.DTOs.Users
{
    public class UserDtoInput : EntityDto<Guid>
    {
        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public UserInfoDtoInput UserInfo { get; set; }
    }

    public class UserDtoOutput : EntityDto<Guid>
    {
        public string Login { get; set; }
        public UserInfoDtoOutput UserInfo { get; set; }
    }
}
