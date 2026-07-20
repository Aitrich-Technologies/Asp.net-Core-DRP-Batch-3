using AutoMapper;
using RazorWorkshop2.Dtos;
using RazorWorkshop2.Models;

namespace RazorWorkshop2.Helper
{
    public class MappingProfile :Profile
    {
        public MappingProfile() {
            CreateMap<User, UserRegisterDto>().ReverseMap();
        }
    }
}
