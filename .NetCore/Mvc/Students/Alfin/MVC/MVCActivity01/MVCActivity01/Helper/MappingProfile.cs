using AutoMapper;
using MVCActivity01.Dto;
using MVCActivity01.Models;

namespace MVCActivity01.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        { CreateMap<User, UserDto>().ReverseMap(); }
    }
}
