using BlazorActivity02.Data;
using BlazorActivity02.Dtos;
using BlazorActivity02.Interface;
using Microsoft.IdentityModel.Tokens;

namespace BlazorActivity02.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void Register(RegisterDto registerdto)
        {
            
            User user = new User();
            user.Name = registerdto.Name;
            user.Email = registerdto.Email;
            user.Password = registerdto.Password;

            _repository.AddUser(user);
        }
        public bool Login(LoginDto loginDto)
        {
            User user = _repository.GetUser(loginDto.Email, loginDto.Password);

            return user != null;

        }
    }
}
