using Blazor_Exercise.Dto;
using Blazor_Exercise.Models;
using Microsoft.Win32;

namespace Blazor_Exercise.Interface
{
    public interface IUserRepository
    {
        Task AddAsync(Users users);
        Task<Users> GetByEmailAsync(string email);
    }
}
