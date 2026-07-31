using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Destinations.DTO
{
    public class DestinationPatchDto
    {
        public string? Name { get; set; }      // nullable
        public string? City { get; set; }      // nullable
        public IFormFile? ImageFile { get; set; }  // nullable

    }
}
