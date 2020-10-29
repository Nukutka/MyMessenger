using AutoMapper;
using MyMessenger.Application.Contracts.DTOs.Users;
using MyMessenger.Domain.Entities.Users;

namespace MyMessenger.Application.Contracts.MapProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDtoInput, User>()
                .ForMember(u => u.HashPassword, o => o.MapFrom(dto => dto.Password));
        }
    }
}
