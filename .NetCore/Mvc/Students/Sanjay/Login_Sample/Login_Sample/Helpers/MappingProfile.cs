using AutoMapper;
using Login_Sample.Dto;
using Login_Sample.Models;

namespace Login_Sample.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Auth, RegisterDto>().ReverseMap();

        }
    }
}
