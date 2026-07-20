using AutoMapper;
using RazorMachineTest2.Dtos;
using RazorMachineTest2.Models;

namespace RazorMachineTest2.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Vehicle, VehicleDto>().ReverseMap();
            CreateMap<User, RegisterDto>().ReverseMap();
        }
    }
}
