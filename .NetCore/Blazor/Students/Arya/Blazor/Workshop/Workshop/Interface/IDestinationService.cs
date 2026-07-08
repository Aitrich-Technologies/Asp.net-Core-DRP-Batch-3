using Workshop.Dto;

namespace Workshop.Interface
{
    public interface IDestinationService
    {
        Task <List<DestinationDto>> GetAllAsync ();
        Task<DestinationDto>GetByIdAsync (int Id);
        Task<bool> AddDestiAsync (DestinationDto destinationDto);
        Task<bool> UpdateDestiAsync (DestinationDto destinationDto);
        Task<bool> DeleteDestiAsync (int Id);
    }
}
