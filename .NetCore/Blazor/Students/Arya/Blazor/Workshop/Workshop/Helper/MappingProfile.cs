using AutoMapper;
using Workshop.Dto;
using Workshop.Models;

namespace Workshop.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {

            CreateMap<Destination, DestinationDto>().ReverseMap();
        }
    }
}
