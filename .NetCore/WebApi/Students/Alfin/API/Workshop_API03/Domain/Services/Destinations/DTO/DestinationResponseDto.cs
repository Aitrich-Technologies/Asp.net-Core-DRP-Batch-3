using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Destinations.DTO
{
    public class DestinationResponseDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? ImageUrl { get; set; }
    }
}
