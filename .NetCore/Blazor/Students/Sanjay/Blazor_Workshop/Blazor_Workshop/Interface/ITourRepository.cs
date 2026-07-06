using Blazor_Workshop.Models;

namespace Blazor_Workshop.Interface
{
    public interface ITourRepository
    {
        Task AddTourAsync(Tour tour);
        Task<List<Tour>> GetAllToursAsync();
    }
}
