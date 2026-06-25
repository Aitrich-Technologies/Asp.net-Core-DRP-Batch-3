using Workshop_Razor.Dto;
using Workshop_Razor.Interface;
using Workshop_Razor.Models;
using Workshop_Razor.Repository;

namespace Workshop_Razor.Service
{
    public class TourService  : ITourService
    {
        private readonly TourRepository tourRepository;

        public TourService(TourRepository _tourRepository)
        {
            tourRepository = _tourRepository;
        }

        public async Task<List<Tours>> GetAllTourAsync()
        {
            return await tourRepository.GetAllTourAsync();
        }

        public async Task<Tours> GetTourByIdAsync(int id)
        {
            return await tourRepository.GetTourByIdAsync(id);
        }

        public async Task AddTourAsync(TourDto jobDto)
        {
            await tourRepository.AddTourAsync(jobDto);
        }

        public async Task UpdateTourAsync(int id, Tours jobDto)
        {
            await tourRepository.UpdateTourAsync(id, jobDto);
        }

        public async Task DeleteTourAsync(int id)
        {
            await tourRepository.DeleteTourAsync(id);
        }
    }
}
