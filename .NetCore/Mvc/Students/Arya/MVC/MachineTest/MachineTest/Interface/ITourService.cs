using MachineTest.Dto;

namespace MachineTest.Interface
{
    public interface ITourService
    {
        Task<List<TourDto>> GetAllToursAsync();
        Task<TourDto?> GetTourByIdAsync(Guid id);
        Task AddTourAsync(TourDto tourDto);
    }
}
