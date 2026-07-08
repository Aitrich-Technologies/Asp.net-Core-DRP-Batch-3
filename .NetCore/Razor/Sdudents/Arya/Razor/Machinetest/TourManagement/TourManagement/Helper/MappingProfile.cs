using AutoMapper;
using TourManagement.Dto;
using TourManagement.Models;

namespace TourManagement.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, GuideDto>().ReverseMap();
            CreateMap<User, RegisterDto>().ReverseMap();
            CreateMap<User, LoginDto>().ReverseMap();
        }

    }
}
