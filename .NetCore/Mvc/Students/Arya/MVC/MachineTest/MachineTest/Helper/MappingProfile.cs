using AutoMapper;
using MachineTest.Dto;
using MachineTest.Models;

namespace MachineTest.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {

            CreateMap<AuthUser, AuthUserDto>().ReverseMap();
            CreateMap<BookingDto, Booking>().ReverseMap();
            CreateMap<Tour, TourDto>().ReverseMap();

        }
    }
}
