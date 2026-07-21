using BlazorWorkshop2.Model;

namespace BlazorWorkshop2.Interface
{
    public interface IDestinationRepository
    {
        Task<List<Destination>> GetAllAsync();
            Task<Destination> GetByIdAsync(int id);
        Task AddAsync(Destination destination);
        Task UpdateAsync(Destination destination);
        Task DeleteAsync(int Id);
    }
}
