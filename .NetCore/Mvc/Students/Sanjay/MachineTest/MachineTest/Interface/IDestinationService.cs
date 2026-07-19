using MachineTest.Dto;

namespace MachineTest.Interface
{
    public interface IDestinationService
    {
        Task<IEnumerable<DestinationResponseDto>> GetAllAsync();
        Task<DestinationResponseDto?> GetByIdAsync(Guid id);
        Task<DestinationResponseDto> CreateAsync(DestinationDto dto);
        Task<DestinationResponseDto?> UpdateAsync(Guid id, DestinationDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
