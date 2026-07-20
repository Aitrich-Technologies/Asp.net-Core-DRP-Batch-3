using AutoMapper;
using BlazorWorkshop2.Dto;
using BlazorWorkshop2.Model;

namespace BlazorWorkshop2.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
         CreateMap<Destination,DestinationDto>().ReverseMap();
           CreateMap<Tour,TourDto>().ReverseMap();
         }
    }
}
