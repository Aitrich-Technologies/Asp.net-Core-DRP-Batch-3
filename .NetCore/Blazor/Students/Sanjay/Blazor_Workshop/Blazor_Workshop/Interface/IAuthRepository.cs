
using Blazor_Workshop.Models;

namespace Blazor_Workshop.Interface
{
    public interface IAuthRepository
    {
        Task<Register> GetByEmailAsync(string email);
        Task AddAsync(Register register);
    }
}
