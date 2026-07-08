using Workshop.Models;

namespace Workshop.Interface
{
    public interface IDestinationRepository
    {
        Task<List<Destination>> GetAllAsync();

        Task<Destination?> GetByIdAsync(int destId);

        Task AddAsync(Destination destination);

        Task UpdateAsync(Destination destination);

        Task DeleteAsync(int destId);
    }
}