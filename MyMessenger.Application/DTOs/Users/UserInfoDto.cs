using AutoMapper;
using MyMessenger.Domain.Entities.Users;
using MyMessenger.Domain.Shared.Enums.Users;
using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace MyMessenger.Application.DTOs.Users
{
    [AutoMap(typeof(User))]
    public class UserInfoDtoInput
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Email { get; set; }
    }

    [AutoMap(typeof(User))]
    public class UserInfoDtoOutput : EntityDto<Guid>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public UserActiveStatuses ActiveStatus { get; set; }
    }
}
