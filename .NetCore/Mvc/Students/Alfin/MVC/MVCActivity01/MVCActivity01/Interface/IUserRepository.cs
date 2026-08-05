

using MVCActivity01.Models;

namespace MVCActivity01.Interface
{
    public interface IUserRepository
    {
        Task<User?> GetUserByEmailAsync(String email);
        Task AddUserAsync(User user);
    }
}
