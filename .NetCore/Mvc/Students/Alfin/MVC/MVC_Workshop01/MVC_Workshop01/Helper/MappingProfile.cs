using AutoMapper;
using MVC_Workshop01.Dto;
using MVC_Workshop01.Models;

namespace MVC_Workshop01.Helper
{
    public class MappingProfile :Profile
    {
        public MappingProfile() 
        {
         CreateMap<TourBookingDto, TourBookingForm>().ReverseMap();
            CreateMap<CreateBookingDto, TourBookingForm>().ReverseMap();

            CreateMap<AuthUser,AuthUserDto>().ReverseMap();
        }
    }
}
