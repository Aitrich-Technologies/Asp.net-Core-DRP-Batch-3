using MachineTest.Models;
namespace MachineTest.Interface
{
    public interface IDestinationRepository
    {
        Task<IEnumerable<Destination>> GetAllAsync();
        Task<Destination?> GetByIdAsync(Guid id);
        Task AddAsync(Destination destination);
        Task UpdateAsync(Destination destination);
        Task DeleteAsync(Destination destination);
        Task SaveChangesAsync();
    }
}
