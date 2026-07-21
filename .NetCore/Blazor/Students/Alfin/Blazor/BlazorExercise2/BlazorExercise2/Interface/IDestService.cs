using BlazorExercise2.Dto;

namespace BlazorExercise2.Interface
{
    public interface IDestService
    {
        Task<List<DestinationDto>> GetAllAsync();
        Task<DestinationDto> GetByIdAsync(int id);
        Task<bool> AddDestiAsync(DestinationDto destDto);
        Task<bool> UpdateDestiAsync(DestinationDto destinationDto);
        Task<bool> DeleteDestiAsync(int id);
    }
}
