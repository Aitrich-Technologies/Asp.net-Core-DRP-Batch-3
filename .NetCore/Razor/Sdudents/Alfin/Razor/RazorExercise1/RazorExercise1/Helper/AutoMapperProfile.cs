using AutoMapper;
using RazorExercise1.Dto;
using RazorExercise1.Model;

namespace RazorExercise1.Helper
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
