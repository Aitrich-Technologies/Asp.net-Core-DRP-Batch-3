using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.User.DTO
{
    public class VerifyCodeDto
    {
        public string Email { get; set; }
        public string Code { get; set; }
        public string VerificationToken { get; set; }
    }
}
