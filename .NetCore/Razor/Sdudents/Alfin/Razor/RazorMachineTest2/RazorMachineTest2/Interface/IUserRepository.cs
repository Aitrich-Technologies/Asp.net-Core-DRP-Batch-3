using RazorMachineTest2.Models;

namespace RazorMachineTest2.Interface
{
    public interface IUserRepository
    {
        Task<User?> GetByUserNameAsync(string username);
        Task AddAsync(User user);
        Task SaveAsync();
    }
}
