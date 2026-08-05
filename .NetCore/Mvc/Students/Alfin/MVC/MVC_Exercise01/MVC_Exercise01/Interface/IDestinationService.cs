using MVC_Exercise01.Dto;

namespace MVC_Exercise01.Interface
{
    public interface IDestinationService
    {
        Task<IEnumerable<DestinationResponseDto>> GetAllAsync();
        Task<DestinationResponseDto?> GetByIdAsync(Guid id);
        Task<DestinationResponseDto?> CreateAsync(DestinationDto dto);

        Task<DestinationResponseDto?> UpdateAsync(Guid id, DestinationDto dto);
        Task<DestinationResponseDto?> PatchAsync(Guid id, DestinationPatchDto patchdto);
        Task<bool> DeleteAsync(Guid id);

    }
}
