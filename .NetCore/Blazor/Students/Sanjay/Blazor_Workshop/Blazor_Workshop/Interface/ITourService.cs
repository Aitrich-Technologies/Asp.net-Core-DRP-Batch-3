using Blazor_Workshop.Dto;
using Blazor_Workshop.Models;

namespace Blazor_Workshop.Interface
{
    public interface ITourService
    {
        Task CreateTourAsync(Tour tour);
        Task<List<TourDto>> GetAllToursAsync();
    }
}
