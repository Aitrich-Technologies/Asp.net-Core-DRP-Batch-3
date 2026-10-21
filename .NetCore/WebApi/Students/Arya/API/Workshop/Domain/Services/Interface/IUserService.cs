using Domain.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Interface
{
    public interface IUserService
    {
        Task<UserResponseDto> AddUserAsync(AddUserDto user);
        Task<string> LoginAsync(LoginDto user);
        Task<string> ForgotPasswordAsync(ForgotUserDto dto);
        Task<string> VerifyCodeAsync(VerifyCodeDto dto);
        Task<bool> ResetPasswordAsync(ResetPasswordDto dto);
        Task<UserResponseDto> GetUserByIdAsync(Guid userId);
        Task SendEmailAsync(string toEmail, string subject, string body);

    }
}
