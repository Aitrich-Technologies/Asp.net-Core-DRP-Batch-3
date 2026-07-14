using AutoMapper;
using MachineTest.Models;
using MachineTest.Dto;

namespace MachineTest.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Destination, DestinationResponseDto>().ReverseMap();
            CreateMap<DestinationDto, Destination>().ReverseMap();
            CreateMap<DestinationPatchDto, Destination>().ReverseMap();
            CreateMap<Auth, AuthUserDto>().ReverseMap();
            CreateMap<DestinationDto, DestinationResponseDto>().ReverseMap();
        }
    }
}
