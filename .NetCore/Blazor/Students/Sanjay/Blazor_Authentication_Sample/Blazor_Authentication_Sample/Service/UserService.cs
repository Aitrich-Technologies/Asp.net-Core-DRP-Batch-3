using Blazor_Authentication_Sample.Data;
using Blazor_Authentication_Sample.Dtos;
using Blazor_Authentication_Sample.Interface;

namespace Blazor_Authentication_Sample.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public void Register(RegisterDto registerDto)
        {
            Users user = new Users();
            user.Name = registerDto.Name;
            user.Email = registerDto.Email;
            user.Password = registerDto.Password;

            _repository.AddUser(user);
        }

        public bool Login(LoginDto loginDto)
        {
          Users  users =  _repository.GetUsers(loginDto.Email, loginDto.Password);

            return users != null;
            
        }
    
    }
}
