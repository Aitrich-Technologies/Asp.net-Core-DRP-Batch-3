using RazorWorkshop2.Models;

namespace RazorWorkshop2.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByUserNameAsync(string userName);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task SaveAsync();


    }
}
