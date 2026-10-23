using AutoMapper;
using MachineTest.DTOs;
using MachineTest.Models;

namespace MachineTest.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<RegisterDto, User>().ReverseMap();

            CreateMap<TourCreateDto, Tour>();
            CreateMap<Tour, TourResponseDto>();
        }
    }
}
