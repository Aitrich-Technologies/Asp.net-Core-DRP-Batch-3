using System.ComponentModel.DataAnnotations;

namespace MachineTest.Models
{
    public class Packages
    {
        [Key]
        public int Id { get; set; }
        public string PackageName { get; set; }
        public int Duration { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
