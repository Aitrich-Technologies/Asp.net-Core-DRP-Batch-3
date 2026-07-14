using AutoMapper;
using BCrypt.Net;
using Login_Sample.Dto;
using Login_Sample.Interface;
using Login_Sample.Models;
namespace Login_Sample.Service
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IMapper _mapper;

        public AuthService(IAuthRepository authRepository, IMapper mapper)
        {
            _authRepository = authRepository;
            _mapper = mapper;
        }

        public async Task<(bool Success, string Error)> RegisterAsync(RegisterDto user, string passwordPlain)
        {
            var existsUser = await _authRepository.GetByUserNameAsync(user.UserName);
            if (existsUser != null) return (false, "User name Exists");
            var newuser = _mapper.Map<Auth>(user);
            newuser.Role = Enum.UserRole.Admin;
            newuser.Password = BCrypt.Net.BCrypt.HashPassword(passwordPlain);
            newuser.Id = Guid.NewGuid();
            
            await _authRepository.CreateAsync(newuser);
            await _authRepository.SaveChangesAsync();
            return (true, null);
        }

        public async Task<(bool Success, Auth User, string Error)> ValidateUserAsync(string username, string passwordPlain)
        {
            Auth user = await _authRepository.GetByUserNameAsync(username);

            if (user == null) return (false, null, "Invalid Username");


            if (!BCrypt.Net.BCrypt.Verify(passwordPlain, user.Password))
                return (false, null, "Invalid password.");
            return (true, user, null);
        }
    }
}
