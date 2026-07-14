using AutoMapper;
using Exercise2.DTO;
using Exercise2.Models;

namespace Exercise2.Helper
{
    public class AppProfile:Profile
    {
        public AppProfile()
        {

            CreateMap<Destination, DestinationResponseDto>().ReverseMap();
            CreateMap<DestinationDto, Destination>().ReverseMap();
            CreateMap<DestinationPathDto, Destination>().ReverseMap();
            CreateMap<AuthUser, AuthUserDto>().ReverseMap();
            CreateMap<DestinationDto, DestinationResponseDto>().ReverseMap();

        }
    }
}
