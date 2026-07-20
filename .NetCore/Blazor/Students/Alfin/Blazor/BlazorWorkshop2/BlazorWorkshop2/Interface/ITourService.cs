using BlazorWorkshop2.Dto;

namespace BlazorWorkshop2.Interface
{
    public interface ITourService
    {
        Task<List<TourDto>> GetAllAsync();
        Task AddAsync(TourDto dto);
    }
}
