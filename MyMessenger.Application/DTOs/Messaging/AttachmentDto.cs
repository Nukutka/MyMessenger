using AutoMapper;
using Microsoft.AspNetCore.Http;
using MyMessenger.Domain.Entities.Messaging;
using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace MyMessenger.Application.DTOs.Messaging
{
    [AutoMap(typeof(Attachment))]
    public class AttachmentDtoInput
    {
        [Required]
        public IFormFile Data { get; set; } 
    }

    [AutoMap(typeof(Attachment))]
    public class AttachmentDtoOutput : EntityDto<Guid>
    {
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public byte[] Data { get; set; }
    }
}
