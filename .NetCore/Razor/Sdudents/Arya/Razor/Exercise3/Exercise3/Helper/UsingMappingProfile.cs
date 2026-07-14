using AutoMapper;
using Exercise3.Dto;
using Exercise3.Dto;
using Exercise3.Models;

namespace Exercise3.Helper
{
    public class UsingMappingProfile : Profile
    {
        public UsingMappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();

            CreateMap<Destination, DestinationDto>()
                .ReverseMap();
        }
    }
}