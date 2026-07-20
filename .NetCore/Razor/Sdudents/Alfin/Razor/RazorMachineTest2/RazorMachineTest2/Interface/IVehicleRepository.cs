using RazorMachineTest2.Dtos;
using RazorMachineTest2.Models;

namespace RazorMachineTest2.Interface
{
    public interface IVehicleRepository
    {
        public Task<Vehicle> GetVehicleByIdAsync(int id);

        Task<List<Vehicle>> GetAllVehicleAsync();
        public Task AddVehicleAsync(VehicleDto VehicleDto);


        public Task UpdateVehicleAsync(int id, Vehicle VehicleDto);

        public Task DeleteVehicleAsync(int id);
    }
}
