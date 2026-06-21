using MachineTest.Models;

namespace MachineTest.Interface
{
    public interface IUserRepository
    {
        Task<User?> GetByUserNameAsync(string username); 
        Task AddAsync(User user);                                           
        Task SaveAsync();
    }
}
