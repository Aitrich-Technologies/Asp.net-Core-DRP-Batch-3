using EmailActivity.Dtos;
using EmailActivity.Models;
using EmailActivity.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmailActivity.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IEmailService _emailService;

        public UserController(
            AppDbContext context,
            IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        // Register User
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            var existingUser = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == dto.Email);

            if (existingUser != null)
            {
                return BadRequest("Email already exists.");
            }

            string token = Guid.NewGuid().ToString();

            var user = new User
            {
                Email = dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                VerificationToken = token,
                IsEmailVerified = false
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            string verificationLink =
                $"https://localhost:7068/api/User/verify-email?token={token}";

            string body = $@"
                <h2>Email Verification</h2>
                <p>Click the button below to verify your email.</p>
                <a href='{verificationLink}'>Verify Email</a>";

            await _emailService.SendEmailAsync(
                dto.Email,
                "Verify Your Email",
                body);

            return Ok("Registration successful. Please check your email.");
        }

        // Verify Email
        [HttpGet("verify-email")]
        public async Task<IActionResult> VerifyEmail(string token)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.VerificationToken == token);

            if (user == null)
            {
                return BadRequest("Invalid verification token.");
            }

            user.IsEmailVerified = true;
            user.VerificationToken = null;

            await _context.SaveChangesAsync();

            return Ok("Email verified successfully.");
        }

        // Login
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == dto.Email);

            if (user == null)
            {
                return Unauthorized("Invalid email or password.");
            }

            bool validPassword = BCrypt.Net.BCrypt.Verify(
                dto.Password,
                user.PasswordHash);

            if (!validPassword)
            {
                return Unauthorized("Invalid email or password.");
            }

            if (!user.IsEmailVerified)
            {
                return BadRequest("Please verify your email before logging in.");
            }

            return Ok("Login successful.");
        }
    }
}