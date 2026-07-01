using Blazor_Authentication_Sample.Dtos;

namespace Blazor_Authentication_Sample.Interface
{
    public interface IUserService
    {
        void Register(RegisterDto registerDto);
        bool Login(LoginDto loginDto);
    }
}
