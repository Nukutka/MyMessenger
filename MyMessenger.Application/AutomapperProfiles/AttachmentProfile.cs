using AutoMapper;
using MyMessenger.Application.DTOs.Messaging;
using MyMessenger.Domain.Entities.Messaging;
using System.IO;

namespace MyMessenger.Application.AutomapperProfiles
{
    public class AttachmentProfile : Profile
    {
        public AttachmentProfile()
        {
            CreateMap<AttachmentDtoInput, Attachment>()
                .ForMember(u => u.Data, o => o.MapFrom(dto => MapIFormFile(dto)))
                .ForMember(u => u.MimeType, o => o.MapFrom(dto => dto.Data.ContentType))
                .ForMember(u => u.FileName, o => o.MapFrom(dto => dto.Data.FileName));
        }

        private byte[] MapIFormFile(AttachmentDtoInput dto)
        {
            using var memoryStream = new MemoryStream();
            dto.Data.CopyTo(memoryStream);

            return memoryStream.ToArray();
        }
    }
}
