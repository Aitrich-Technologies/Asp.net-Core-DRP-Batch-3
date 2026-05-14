using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.Models
{
    internal class Consultant
    {
    public int ConsultantId { get; set; }
        public string Name { get; set; }
        public int AssignedCustomers { get; set; }
        public int UserId { get; set; } 
    }
}
