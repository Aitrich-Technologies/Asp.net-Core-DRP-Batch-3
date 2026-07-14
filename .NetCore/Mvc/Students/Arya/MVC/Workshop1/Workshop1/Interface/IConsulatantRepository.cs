using Workshop1.Models;

namespace Workshop1.Interface
{
    public interface IConsulatantRepository
    {
        Task<List<User>> GetAllConsultantsAsync();
        Task<User?> GetByIdAsync(Guid id);
        Task AddAsync(User user);
        Task SaveAsync();
    }
}
