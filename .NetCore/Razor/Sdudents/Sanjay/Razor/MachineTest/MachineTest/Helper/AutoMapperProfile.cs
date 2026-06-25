using AutoMapper;
using MachineTest.Dto;
using MachineTest.Models;

namespace MachineTest.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Packages, PackageDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();

        }
    }
}
