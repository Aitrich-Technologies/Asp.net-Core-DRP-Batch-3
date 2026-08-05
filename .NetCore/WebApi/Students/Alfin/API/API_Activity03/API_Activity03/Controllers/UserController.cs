using API_Activity03.Model;
using API_Activity03.service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API_Activity03.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserDbContext _userDbContext;
        private readonly IConfiguration configuration;
        private readonly IEmailService _emailService;
        public UserController(UserDbContext userDbContext, IConfiguration _configuration, IEmailService emailService)
        {

            _userDbContext = userDbContext;
            configuration = _configuration;
            _emailService = emailService;
        }

        [HttpPost]
        [Route("Registration")]
        public async Task<IActionResult> Registration(UserDto userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var objUser = _userDbContext.users.FirstOrDefault(x => x.Email == userDto.Email);

            string token = Guid.NewGuid().ToString();


            if (objUser == null)
            {
                _userDbContext.users.Add(new Model.User
                {
                    FirstName = userDto.FirstName,
                    LastName = userDto.LastName,
                    Email = userDto.Email,
                    Password = userDto.Password,
                    Role = userDto.Role,
                    VerificationToken = token,
                    IsEmailVerified = false
                });
                _userDbContext.SaveChanges();
                string verificationLink =
               $"https://localhost:7068/api/auth/verify-email?token={token}";

                string body = $@"
            <h2>Email Verification</h2>
            <p>Please click the link below:</p>
            <a href='{verificationLink}'>
                Verify Email
            </a>";

                await _emailService.SendEmailAsync(
                    userDto.Email,
                    "Verify Your Email",
                    body);

                return Ok("Registration successful. Check your email.");
                
            }
            else
            {
                return BadRequest("User Already Exists with same email address");
            }
        }

        [HttpGet("verify-email")]
        public async Task<IActionResult> VerifyEmail(string token)
        {
            var user = await _userDbContext.users.FirstOrDefaultAsync(x => x.VerificationToken == token);

            if (user == null)
                return BadRequest("Invalid token");

            user.IsEmailVerified = true;
            user.VerificationToken = null;

            await _userDbContext.SaveChangesAsync();

            return Ok("Email verified successfully");
        }


        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginDto loginDto)
        {
            var user = _userDbContext.users.FirstOrDefault(x => x.Email == loginDto.Email && x.Password == loginDto.Password);
            if (user != null)
            {
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email ?? ""),                    
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim("UserId", user.UserId.ToString()),
                    new Claim("Email", user.Email),
                    new Claim(ClaimTypes.Role, user.Role.ToString())
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"]));

                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    configuration["JWT:Issuer"],
                    configuration["JWT:Audience"],
                    claims, expires: DateTime.UtcNow.AddMinutes(60),
                    signingCredentials: signIn
                    );

                string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
                return Ok(new { Token = tokenValue, User = user });
            }
            return NoContent();

        }


        [HttpGet]
        [Route("GetUser")]
        [Authorize(Roles = "ADMIN,CUSTOMER,CONSULTANT")]
        public IActionResult GetUser(int id)
        {
            var user = _userDbContext.users.FirstOrDefault(x => x.UserId == id);
            if (user != null)
            {
                return Ok(user);
            }
            else
                return NoContent();
        }

        [HttpDelete]
        [Route("DeleteUser")]
        [Authorize(Roles = "ADMIN,CUSTOMER,CONSULTANT")]
        public IActionResult DeleteUser(int id)
        {
            var user = _userDbContext.users.FirstOrDefault(x => x.UserId == id);
            if (user != null)
            {
                _userDbContext.users.Remove(user);
                _userDbContext.SaveChanges();
                return Ok("User Deleted Successfully");
            }
            return NotFound("User Not Found");
        }
    }
}
