using AutoMapper;
using Blazor_Workshop.Dto;
using Blazor_Workshop.Models;

namespace Blazor_Workshop.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Register, RegisterDto>().ReverseMap();
            CreateMap<Tour, TourDto>().ReverseMap();

        }
    }
}
