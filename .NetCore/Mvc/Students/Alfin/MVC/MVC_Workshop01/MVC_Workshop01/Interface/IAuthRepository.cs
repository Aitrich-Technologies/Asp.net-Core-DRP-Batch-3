using MVC_Workshop01.Models;

namespace MVC_Workshop01.Interface
{
    public interface IAuthRepository
    {
        Task<AuthUser?> GetByEmailAsync(string email);
        Task<AuthUser?> GetByUserNameAsync(string username);
        Task<AuthUser> GetByIdAsync(Guid Id);
        Task CreateAsync(AuthUser user);
        Task SaveChangesAsync();
    }
}
