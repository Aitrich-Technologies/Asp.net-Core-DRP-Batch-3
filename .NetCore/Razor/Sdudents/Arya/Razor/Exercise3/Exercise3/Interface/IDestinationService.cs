using Exercise3.Dto;

namespace Exercise3.Interface
{
    public interface IDestinationService
    {
        Task<List<DestinationDto>> GetAll();

        Task<DestinationDto?> GetById(int id);

        Task Add(DestinationDto destinationDto);

        Task Update(DestinationDto destinationDto);

        Task Delete(int id);
    }
}
