using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public partial class TermsAndCondition
    {
        public Guid Id { get; set; }

        public Guid TourId { get; set; }

        public string? Terms { get; set; }

        public virtual Tourss Tour { get; set; } = null!;
    }
}
