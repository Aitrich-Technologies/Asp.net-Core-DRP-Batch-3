using AutoMapper;
using Workshop_Razor.Dto;
using Workshop_Razor.Models;

namespace Workshop_Razor.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Tours, TourDto>().ReverseMap();
        }
    }
}
