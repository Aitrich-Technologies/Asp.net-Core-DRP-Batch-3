using Auth_Sample.Models;

namespace Auth_Sample.Interface
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmailAsync(string email);
        Task AddUserAsync(User user);

    }
}
