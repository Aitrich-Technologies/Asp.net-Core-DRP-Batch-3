using AutoMapper;
using Login.Dtos;
using Login.Model;

namespace Login.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        { 
             CreateMap<User,UserRegisterDto>().ReverseMap();
        }
    }
}
