using MachineTest.Models;

namespace MachineTest.Interface
{
    public interface IAuthRepository
    {
        Task<Auth?> GetByEmailAsync(string email);
        Task<Auth> GetByIdAsync(Guid id);
        Task CreateAsync(Auth user);
        Task SaveChangesAsync();
    }
}
