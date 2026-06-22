using Exercise.Dto;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using AutoMapper;
using Exercise.Models;

namespace Exercise.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Consultants, ConsultantDto>().ReverseMap();
            CreateMap<Register, RegisterDto>().ReverseMap();

        }
    }
}
