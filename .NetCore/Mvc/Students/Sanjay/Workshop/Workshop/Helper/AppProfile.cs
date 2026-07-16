using AutoMapper;
using Workshop.Dto;
using Workshop.Models;

namespace Workshop.Helper
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {

            CreateMap<Destination, DestinationResponseDto>().ReverseMap();
            CreateMap<DestinationDto, Destination>().ReverseMap();
            CreateMap<DestinationPatchDto, Destination>().ReverseMap();
            CreateMap<AuthUser, AuthUserDto>().ReverseMap();
            CreateMap<DestinationDto, DestinationResponseDto>().ReverseMap();

        }
    }
}
