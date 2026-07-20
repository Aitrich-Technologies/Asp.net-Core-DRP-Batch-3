using BlazorWorkshop2.Dto;
using BlazorWorkshop2.Model;

namespace BlazorWorkshop2.Interface
{
    public interface IDestinationService
    {
        Task<List<DestinationDto>> GetAllAsync();
        Task<DestinationDto> GetByIdAsync(int Id);
        Task AddAsync(DestinationDto dto);
        Task UpdateAsync(DestinationDto dto);
        Task DeleteAsync(int Id);
    }
}
