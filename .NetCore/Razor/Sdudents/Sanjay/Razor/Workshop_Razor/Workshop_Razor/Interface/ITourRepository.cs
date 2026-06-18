using Workshop_Razor.Dto;
using Workshop_Razor.Models;

namespace Workshop_Razor.Interface
{
    public interface ITourRepository
    {
        public Task<List<Tours>> GetAllTourAsync();

        public Task<Tours> GetTourByIdAsync(int id);


        public Task AddTourAsync(TourDto jobDto);


        public Task UpdateTourAsync(int id, Tours jobDto);

        public Task DeleteTourAsync(int id);
    }
}
