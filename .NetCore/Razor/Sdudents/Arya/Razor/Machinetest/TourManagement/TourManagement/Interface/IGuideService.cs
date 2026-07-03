using TourManagement.Dto;
using TourManagement.Models;

namespace TourManagement.Interface
{
    public interface IGuideService
    {
        Task<List<Guide>> GetAllGuidesAsync();
        Task<Guide?> GetGuideByIdAsync(int id);
        Task AddGuideAsync(GuideDto dto);
        Task UpdateGuideAsync(GuideDto dto);
        Task DeleteGuideAsync(int id);
    }
}