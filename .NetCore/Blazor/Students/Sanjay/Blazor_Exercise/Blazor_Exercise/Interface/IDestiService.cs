using Blazor_Exercise.Dto;
namespace Blazor_Exercise.Interface
{
    public interface IDestiService
    {
        Task<List<DestinationnDto>> GetAllAsync();
        Task<DestinationnDto> GetByIdAsync(int id);
        Task<bool> AddDestiAsync(DestinationnDto destnDto);
        Task<bool> UpdateDestiAsync(DestinationnDto destinationnDto);
        Task<bool> DeleteDestiAsync(int id);
    }
}
