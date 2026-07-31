using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Services.Destinations.DTO
{
    public class DestinationUpdateDto
    {
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string City { get; set; } = null!;

        public IFormFile? ImageFile { get; set; }
    }
}
