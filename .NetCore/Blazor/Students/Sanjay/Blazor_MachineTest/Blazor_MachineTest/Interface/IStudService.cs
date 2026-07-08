using Blazor_MachineTest.Dto;
using Blazor_MachineTest.Model;

namespace Blazor_MachineTest.Interface
{
    public interface IStudService
    {
        Task<bool> AddAsync(StudentDto studentDto);
        Task<bool> UpdateAsync(StudentDto studentDto);
        Task<bool> DeleteAsync(int id);
        Task<List<StudentDto>> GetAllAsync();
        Task<StudentDto> GetByIdAsync(int id);
    }
}
