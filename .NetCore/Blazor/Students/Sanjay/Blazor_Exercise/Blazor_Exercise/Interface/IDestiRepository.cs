using Blazor_Exercise.Models;

namespace Blazor_Exercise.Interface
{
    public interface IDestiRepository
    {
        Task<List<Destinationn>> GetAllAsync();
        Task<Destinationn> GetByIdAsync(int destiId);
        Task AddAsync(Destinationn destinationn);
        Task UpdateAsync(Destinationn destinationn);
        Task DeleteAsync(int destiId);
    }
}
