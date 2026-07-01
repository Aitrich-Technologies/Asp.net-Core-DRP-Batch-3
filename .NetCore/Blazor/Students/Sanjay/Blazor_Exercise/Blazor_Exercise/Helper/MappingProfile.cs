using AutoMapper;
using Blazor_Exercise.Dto;
using Blazor_Exercise.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Blazor_Exercise.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Users, RegisterDto>().ReverseMap();
        }
    }
}
