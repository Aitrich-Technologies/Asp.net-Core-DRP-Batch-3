using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Destinations.DTO
{
    public class DestinationPatchDto
    {
        public string? Name { get; set; }      
        public string? City { get; set; }     
        public IFormFile? ImageFile { get; set; }
    }
}
