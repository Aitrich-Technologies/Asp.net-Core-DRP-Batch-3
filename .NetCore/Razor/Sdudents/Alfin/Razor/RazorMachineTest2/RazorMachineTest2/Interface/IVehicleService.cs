using RazorMachineTest2.Dtos;
using RazorMachineTest2.Models;

namespace RazorMachineTest2.Interface
{
    public interface IVehicleService
    {
        public Task<List<Vehicle>> GetAllVehicleAsync();

        public Task<Vehicle> GetVehicleByIdAsync(int id);


        public Task AddVehicleAsync(VehicleDto VehicleDto);


        public Task UpdateVehicleAsync(int id, Vehicle VehicleDto);

        public Task DeleteVehicleAsync(int id);
    }
}
