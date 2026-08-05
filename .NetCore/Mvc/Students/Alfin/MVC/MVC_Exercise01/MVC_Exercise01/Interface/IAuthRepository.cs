using MVC_Exercise01.Models;

namespace MVC_Exercise01.Interface
{
    public interface IAuthRepository
    {
        Task<AuthUser?> GetByEmailAsync(string email);
        Task<AuthUser?> GetByUserNameAsync(string username);
        Task<AuthUser> GetByIdAsync(Guid id);
        Task CreateAsync(AuthUser user);
        Task SaveChangesAsync();
    }
}
