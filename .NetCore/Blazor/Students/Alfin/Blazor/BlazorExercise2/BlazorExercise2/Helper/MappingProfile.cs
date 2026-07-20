using AutoMapper;
using BlazorExercise2.Dto;
using BlazorExercise2.Model;

namespace BlazorExercise2.Helper
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Users, RegisterDto>().ReverseMap();
        }
    }
}
