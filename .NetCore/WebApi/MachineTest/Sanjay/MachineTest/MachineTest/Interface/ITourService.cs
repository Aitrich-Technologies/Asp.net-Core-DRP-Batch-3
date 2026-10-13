using MachineTest.DTOs;

namespace MachineTest.Interface
{
    public interface ITourService
    {
        Task<TourResponseDto> AddAsync(TourCreateDto dto, Guid createdBy);

        Task<List<TourResponseDto>> GetAllAsync();

        Task<TourResponseDto?> GetByIdAsync(Guid id);
    }
}
