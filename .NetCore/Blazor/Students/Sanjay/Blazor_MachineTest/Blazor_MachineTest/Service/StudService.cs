using AutoMapper;
using Blazor_MachineTest.Dto;
using Blazor_MachineTest.Interface;
using Blazor_MachineTest.Model;

namespace Blazor_MachineTest.Service
{
    public class StudService : IStudService
    {
        public readonly IStudRepository _studRepository;
        public readonly IMapper _mapper;
        public StudService(IStudRepository studRepository, IMapper mapper)
        {
            _mapper = mapper;
            _studRepository = studRepository;
        }

        public async Task<bool> AddAsync(StudentDto studentDto)
        {
            var student = _mapper.Map<Student>(studentDto);
            await _studRepository.AddAsync(student);
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await _studRepository.DeleteAsync(id);
            return true;
        }

        public async Task<List<StudentDto>> GetAllAsync()
        {
            var studList = await _studRepository.GetAllAsync();
            return _mapper.Map<List<StudentDto>>(studList);
        }

        public async Task<StudentDto> GetByIdAsync(int id)
        {
            var stud = await _studRepository.GetByIdAsync(id);

            if (stud == null)
                return null;

            return _mapper.Map<StudentDto>(stud);
        }

        public async Task<bool> UpdateAsync(StudentDto studentDto)
        {
            var stud = await _studRepository.GetByIdAsync(studentDto.Id);

            if (stud == null)
                return false;

            _mapper.Map(studentDto, stud);
            await _studRepository.UpdateAsync(stud);

            return true;
        }
    }
}

       