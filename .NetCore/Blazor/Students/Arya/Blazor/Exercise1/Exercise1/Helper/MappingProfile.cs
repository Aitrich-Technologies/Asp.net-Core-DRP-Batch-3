using AutoMapper;
using Exercise1.Dto;
using Exercise1.Models;

namespace Exercise1.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterDto, User>();

            CreateMap<TourDto, Tour>().ReverseMap();
        }
    }
}
