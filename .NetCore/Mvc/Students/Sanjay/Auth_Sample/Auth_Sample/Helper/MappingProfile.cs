using Auth_Sample.Models;
using AutoMapper;
using Auth_Sample.Dto;
using Microsoft.EntityFrameworkCore;

namespace Auth_Sample.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UseDto>().ReverseMap();
        }

    }
}
