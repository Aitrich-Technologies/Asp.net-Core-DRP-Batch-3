using Blazor_MachineTest.Model;

namespace Blazor_MachineTest.Interface
{
    public interface IStudRepository
    {
        Task<List<Student>> GetAllAsync();
        Task<Student> GetByIdAsync(int id);
        Task AddAsync(Student student);
        Task UpdateAsync(Student student);
        Task DeleteAsync(int id);
    }
}
