using ActivityJWT.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics.Eventing.Reader;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ActivityJWT.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IConfiguration configuration;
        public UserController(AppDbContext appDbContext, IConfiguration _configuration)
        {

            _appDbContext = appDbContext;
            configuration = _configuration;
        }

        [HttpPost]
        [Route("Registration")]
        public IActionResult Registration(UserDto userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var objUser = _appDbContext.users.FirstOrDefault(x => x.Email == userDto.Email);
            if (objUser == null)
            {
                _appDbContext.users.Add(new Model.User
                {
                    FirstName = userDto.FirstName,
                    LastName = userDto.LastName,
                    Email = userDto.Email,
                    Password = userDto.Password,
                    Role = userDto.Role,
                });
                _appDbContext.SaveChanges();
                return Ok("User Registered Successfully");
            }
            else
            {
                return BadRequest("User Already Exists with same email address");
            }
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginDto loginDto)
        {
            var user = _appDbContext.users.FirstOrDefault(x => x.Email == loginDto.Email && x.Password == loginDto.Password);
            if (user != null)
            {
                var claims = new[]
                {
                     new Claim(JwtRegisteredClaimNames.Sub, configuration["JWT:Subject"]),
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
                    claims,
                    expires: DateTime.UtcNow.AddMinutes(60),
                    signingCredentials: signIn
                    );

                string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
                return Ok(new { Token = tokenValue, User = user });
            }
            return NoContent();
        }

        [HttpGet]
        [Route("GetUser")]
        [Authorize(Roles = "CUSTOMER")]
        public IActionResult GetUser(int id)
        {
            var user = _appDbContext.users.FirstOrDefault(x => x.UserId == id);
            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return NoContent();
            }
        }

            [HttpDelete]
            [Route("DeleteUser")]
            [Authorize(Roles = "ADMIN,CONSULTANT,CUSTOMER")]
            public IActionResult DeleteUser(int id)
            {
                var user = _appDbContext.users.FirstOrDefault(x => x.UserId == id);
                if (user != null)
                {
                    _appDbContext.users.Remove(user);
                    _appDbContext.SaveChanges();
                    return Ok("User Deleted Successfully");
                }
                return NotFound("User Not Found");
            }



        }
            

    
            


    
}
