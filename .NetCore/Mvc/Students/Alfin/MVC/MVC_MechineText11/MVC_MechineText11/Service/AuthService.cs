using AutoMapper;
using MVC_MechineText11.Dto;
using MVC_MechineText11.Enum;
using MVC_MechineText11.Interface;
using MVC_MechineText11.Models;

namespace MVC_MechineText11.Service
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _repo;
        private readonly IMapper _mapper;

        public AuthService(IAuthRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<(bool Success, string? Error)> RegisterAsync(RegisterDto user, string passwordPlain)
        {
            var existsEmail = await _repo.GetByEmailAsync(user.Email);
            if (existsEmail != null) return (false, "Email already exists.");

            var existsUser = await _repo.GetByUserNameAsync(user.AgencyName);
            if (existsUser != null) return (false, "Username already exists.");
            var newuser = _mapper.Map<Agency>(user);
            newuser.Role = UserRole.Agency;
            newuser.Password = BCrypt.Net.BCrypt.HashPassword(passwordPlain);
            newuser.Id = Guid.NewGuid();


            await _repo.CreateAsync(newuser);
            await _repo.SaveChangesAsync();
            return (true, null);
        }

        public async Task<(bool Success, Agency? User, string? Error)> ValidateUserAsync(string email, string passwordPlain)
        {
            Agency user = await _repo.GetByEmailAsync(email);

            if (user == null) return (false, null, "Invalid email");
            var password = BCrypt.Net.BCrypt.HashPassword(passwordPlain);
            if (!BCrypt.Net.BCrypt.Verify(passwordPlain, user.Password))
                return (false, null, "Invalid password.");
            return (true, user, null);
        }
    }
}
