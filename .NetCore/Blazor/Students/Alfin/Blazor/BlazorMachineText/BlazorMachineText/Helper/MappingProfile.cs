using AutoMapper;
using BlazorMachineText.Components.Pages;
using BlazorMachineText.Dto;

namespace BlazorMachineText.Helper
{
    public class MappingProfile : Profile
    {
            public MappingProfile()
        {
            CreateMap<Login, LoginDto>().ReverseMap();
        }
    }
    
}
