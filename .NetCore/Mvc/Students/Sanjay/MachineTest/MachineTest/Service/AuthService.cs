using AutoMapper;
using MachineTest.Dto;
using MachineTest.Models;
using MachineTest.Interface;
using MachineTest.Repository;

namespace MachineTest.Service
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

        public async Task<(bool Success, string? Error)> RegisterAsync(AuthUserDto user, string passwordPlain)
        {
            var existsEmail = await _authRepository.GetByEmailAsync(user.Email);
            if (existsEmail != null) return (false, "Email already exists.");

            var newuser = _mapper.Map<Auth>(user);
            newuser.Role = Enum.UserRole.Admin;
            newuser.Password = BCrypt.Net.BCrypt.HashPassword(passwordPlain);
            newuser.Id = Guid.NewGuid();

            await _authRepository.CreateAsync(newuser);
            await _authRepository.SaveChangesAsync();
            return (true, null);
        }

        public async Task<(bool Success, Auth? User, string? Error)> ValidateUserAsync(string Email, string passwordPlain)
        {
            Auth? user = await _authRepository.GetByEmailAsync(Email);

            if (user == null) return (false, null, "Invalid email.");

            if (!BCrypt.Net.BCrypt.Verify(passwordPlain, user.Password))
                return (false, null, "Invalid password.");
            return (true, user, null);
        }
    }
}
