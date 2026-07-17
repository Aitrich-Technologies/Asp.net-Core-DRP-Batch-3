using MachineTest.Models;

namespace MachineTest.Interface
{
    public interface ITourRepository
    {
        Task<List<Tour>> GetAllToursAsync();
        Task<Tour?> GetTourByIdAsync(Guid id);
        Task AddTourAsync(Tour tour);
    }
}