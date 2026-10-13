using MachineTest.Models;

namespace MachineTest.Interface
{
    public interface ITourRepository
    {
        Task<Tour> AddAsync(Tour tour);
        Task<List<Tour>> GetAllAsync();
        Task<Tour?> GetByIdAsync(Guid id);
    }
}
