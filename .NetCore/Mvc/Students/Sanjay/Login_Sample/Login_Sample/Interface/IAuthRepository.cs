using Login_Sample.Models;

namespace Login_Sample.Interface
{
    public interface IAuthRepository
    {
        Task<Auth?> GetByUserNameAsync(string username);
        Task<Auth> GetByIdAsync(Guid id);
        Task CreateAsync(Auth user);
        Task SaveChangesAsync();
    }
}
