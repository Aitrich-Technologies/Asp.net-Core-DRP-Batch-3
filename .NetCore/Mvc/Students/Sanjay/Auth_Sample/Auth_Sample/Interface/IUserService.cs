using Auth_Sample.Dto;

namespace Auth_Sample.Interface
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(RegisterDto registerDto);
        Task<UseDto> LoginAsync(LoginDto loginDto);

    }
}
