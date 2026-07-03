using Login.Dtos;
using Login.Model;

namespace Login.Interfacce
{
    public interface IUserService
    {
        Task<bool> RegisterAsync(UserRegisterDto dto);
        Task<User?>LoginAsync (UserLoginDto dto);
        Task <bool> ChangePasswordAsync (UserChangePasswordDto dto);
    }
}
