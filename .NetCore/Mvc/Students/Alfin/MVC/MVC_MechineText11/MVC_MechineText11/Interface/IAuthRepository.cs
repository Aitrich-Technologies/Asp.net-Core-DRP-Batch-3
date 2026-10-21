using MVC_MechineText11.Models;

namespace MVC_MechineText11.Interface
{
    public interface IAuthRepository
    {
        Task<Agency?> GetByEmailAsync(string email);
        Task<Agency?> GetByUserNameAsync(string username);

        Task<Agency> GetByIdAsync(Guid Id);
        Task CreateAsync(Agency user);
        Task SaveChangesAsync();

    }
}
