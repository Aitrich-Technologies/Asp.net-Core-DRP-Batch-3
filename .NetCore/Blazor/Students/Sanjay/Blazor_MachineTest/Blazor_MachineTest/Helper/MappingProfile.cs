using AutoMapper;
using Blazor_MachineTest.Dto;
using Blazor_MachineTest.Model;

namespace Blazor_MachineTest.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentDto, Student>();
            CreateMap<Student, StudentDto>();
        }
    }
}
