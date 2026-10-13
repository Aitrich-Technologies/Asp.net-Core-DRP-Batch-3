using AutoMapper;
using MachineTest.DTOs;
using MachineTest.Interface;
using MachineTest.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MachineTest.Services
{
    public class UserService : IUserService
    {
        public readonly IMapper _mapper;
        public readonly IUserRepository _userRepository;
        private readonly IConfiguration _config;


        public UserService(IMapper mapper, IUserRepository userRepository, IConfiguration configuration)
        {
            _mapper = mapper;
            _config = configuration;
            _userRepository = userRepository;
        }

        public async Task<RegisterDto> RegisterAsync(RegisterDto dto)
        {
            var user = _mapper.Map<User>(dto);

            user.Id = Guid.NewGuid();
            await _userRepository.RegisterAsync(user);

            return _mapper.Map<RegisterDto>(user);
        }

        public async Task<string> LoginAsync(LoginDto login)
        {
            var user = await _userRepository.LoginAsync(login.Email, login.Password);
            if (user == null)
                return null;

            return GenerateJwtToken(user);
        }

        private string GenerateJwtToken(User user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Name),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
                new Claim("UserId", user.Id.ToString()),
                
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creads = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: creads
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }


}
