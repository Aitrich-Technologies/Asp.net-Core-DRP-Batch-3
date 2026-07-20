using System.ComponentModel.DataAnnotations;

namespace RazorMachineTest2.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string VehicleName { get; set; }
        public string VehicleType { get; set; }
        public int SeatCapacity { get; set; }
        public string DriverName { get; set; }
    }
}
