using AutoMapper;
using Microsoft.AspNetCore.Http;
using MyMessenger.Application.DTOs.Abstraction;
using MyMessenger.Domain.Entities.Messaging;
using System.ComponentModel.DataAnnotations;

namespace MyMessenger.Application.DTOs.Messaging
{
    [AutoMap(typeof(Attachment), ReverseMap = true)]
    public class AttachmentDtoInput : BaseDtoInput
    {
        [Required]
        public IFormFile Data { get; set; } 
    }

    [AutoMap(typeof(Attachment))]
    public class AttachmentDtoOutput : BaseDtoOutput
    {
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public byte[] Data { get; set; }
    }
}
