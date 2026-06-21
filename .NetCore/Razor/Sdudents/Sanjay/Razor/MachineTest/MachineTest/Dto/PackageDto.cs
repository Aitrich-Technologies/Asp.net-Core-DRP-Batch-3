using System.ComponentModel.DataAnnotations;

namespace MachineTest.Dto
{
    public class PackageDto
    {
        [Key]
        public string PackageName { get; set; }
        public int Duration { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
