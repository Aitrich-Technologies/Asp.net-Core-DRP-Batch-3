using System.ComponentModel.DataAnnotations;

namespace RazorMachineTest2.Dtos
{
    public class VehicleDto
    {
        [Key]
        public string VehicleName { get; set; }
        public string VehicleType { get; set; }
        public int SeatCapacity { get; set; }
        public string DriverName { get; set; }
    }
}
