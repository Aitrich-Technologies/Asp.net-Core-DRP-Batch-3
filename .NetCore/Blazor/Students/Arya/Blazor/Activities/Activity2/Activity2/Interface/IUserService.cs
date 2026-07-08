using Activity2.Dto;

namespace Activity2.Interface
{
    public interface IUserService
    {
        void Register(RegisterDto dto);
        bool Login(LoginDto dto);
    }
}
