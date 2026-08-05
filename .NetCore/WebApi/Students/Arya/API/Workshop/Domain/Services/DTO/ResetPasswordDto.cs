using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.DTO
{
    public class ResetPasswordDto
    {
        public string Email { get; set; } = string.Empty;

        public string NewPassword { get; set; } = string.Empty;
    }
}
