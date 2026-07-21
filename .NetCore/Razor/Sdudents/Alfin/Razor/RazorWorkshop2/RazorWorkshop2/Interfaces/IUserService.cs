using RazorWorkshop2.Dtos;
using RazorWorkshop2.Models;

namespace RazorWorkshop2.Interfaces
{
    public interface IUserService
    {
        Task<bool> RegisterAsync(UserRegisterDto dto);
        Task<User?> LoginAsync(UserLoginDto dto);
        Task<bool> ChangePasswordAsync(UserchangePasswordDto dto);
    }
}
