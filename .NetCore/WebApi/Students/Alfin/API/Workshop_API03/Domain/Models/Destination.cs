using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public partial class Destination
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? City { get; set; }

       
        public string? ImageUrl { get; set; }

        public virtual ICollection<Tourss> Tours { get; set; } = new List<Tourss>();
    }
}
