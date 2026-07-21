
using BlazorWorkshop2.Model;

namespace BlazorWorkshop2.Interface
{
    public interface  ITourRepository
    {
        Task<List<Tour>> GetAllAsync();
        Task AddAsync(Tour tour);
    }
}
