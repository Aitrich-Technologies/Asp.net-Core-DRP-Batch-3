//using Microsoft.AspNetCore.Components;
using AutoMapper;
using MachineTest.DTOs;
using MachineTest.Interface;
using MachineTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace MachineTest.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController:ControllerBase
    {
        public readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _userService.RegisterAsync(dto);
            return Ok();
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto login)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var Token = await _userService.LoginAsync(login);
            if (Token == null)
                return Unauthorized("Invalid Credintional");

            return Ok(new { Token });
        }


    }
}
