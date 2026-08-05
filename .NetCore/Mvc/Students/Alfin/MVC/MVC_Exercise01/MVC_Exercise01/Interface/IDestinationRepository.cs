using MVC_Exercise01.Models;

namespace MVC_Exercise01.Interface
{
    public interface IDestinationRepository
    {
        Task<IEnumerable<Destination>> GetAllAsync();
        Task<Destination?> GetByIdAsync(Guid id);
        Task AddAsync(Destination destination);
        Task UpdateAsync(Destination destination);
        Task DeleteAsync(Destination destination);
        Task<bool> ExistsAsync(Guid id);
        Task SaveChangesAsync();
    }
}
