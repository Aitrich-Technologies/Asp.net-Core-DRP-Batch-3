using BlazorExercise2.Model;

namespace BlazorExercise2.Interface
{
    public interface IDestRepository
    {
        Task<List<Destination>> GetAllAsync();
        Task<Destination> GetByIdAsync(int destiId);
        Task AddAsync(Destination destination);
        Task UpdateAsync(Destination destination);
        Task DeleteAsync(int destiId);
    }
}
