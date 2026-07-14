using AutoMapper;
using MVC_Exercise.Dto;
using MVC_Exercise.Models;

namespace MVC_Exercise.Helper
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
