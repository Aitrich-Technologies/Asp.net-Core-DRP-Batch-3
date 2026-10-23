using MachineTest.Models;

namespace MachineTest.Interface
{
    public interface IUserRepository
    {
        Task<User> RegisterAsync(User user);
        Task<User> LoginAsync(string username, string password);

       

    }
}
