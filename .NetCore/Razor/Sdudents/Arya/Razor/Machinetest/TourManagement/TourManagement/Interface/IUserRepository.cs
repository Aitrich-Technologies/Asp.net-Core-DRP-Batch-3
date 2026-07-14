using TourManagement.Models;

namespace TourManagement.Interface
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task<User?> GetByUserNameAsync(string userName);
        Task SaveAsync();

        Task<User?> GetByIdAsync(int id);
        Task UpdateAsync(User user);
    }
}