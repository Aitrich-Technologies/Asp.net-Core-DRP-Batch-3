using TourManagement.Models;

using TourManagement.Models;

namespace TourManagement.Interface
{
    public interface IGuideRepository
    {
        Task<List<Guide>> GetAllAsync();

        Task<Guide?> GetByIdAsync(int id);

        Task AddAsync(Guide guide);

        Task UpdateAsync(Guide guide);

        Task DeleteAsync(Guide guide);

        Task SaveAsync();
    }
}