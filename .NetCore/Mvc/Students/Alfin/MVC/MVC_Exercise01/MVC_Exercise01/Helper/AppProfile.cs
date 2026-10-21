using AutoMapper;
using MVC_Exercise01.Dto;
using MVC_Exercise01.Models;

namespace MVC_Exercise01.Helper
{
    public class AppProfile :Profile
    {
        public AppProfile() 
        {
         CreateMap<Destination, DestinationResponseDto>().ReverseMap();
            CreateMap<DestinationDto, Destination>().ReverseMap();
            CreateMap<DestinationPatchDto,Destination>().ReverseMap();
            CreateMap<AuthUser,AuthUserDto>().ReverseMap();
            CreateMap<DestinationDto,DestinationResponseDto>().ReverseMap();
        }
    }
}
