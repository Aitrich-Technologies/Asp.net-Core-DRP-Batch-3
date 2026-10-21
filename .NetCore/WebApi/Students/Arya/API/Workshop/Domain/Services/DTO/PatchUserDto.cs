using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.DTO
{
    public class PatchUserDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? Role { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? TelephoneNo { get; set; }
    }
}
