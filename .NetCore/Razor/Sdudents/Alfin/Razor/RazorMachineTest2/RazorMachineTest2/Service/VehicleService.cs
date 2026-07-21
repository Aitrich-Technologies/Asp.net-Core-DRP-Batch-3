using RazorMachineTest2.Dtos;
using RazorMachineTest2.Interface;
using RazorMachineTest2.Models;
using RazorMachineTest2.Repository;
namespace RazorMachineTest2.Service
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _VehicleRepository;

        public VehicleService(IVehicleRepository VehicleRepository)
        {
            _VehicleRepository = VehicleRepository;
        }

        public async Task<List<Vehicle>> GetAllVehicleAsync()
        {
            return await _VehicleRepository.GetAllVehicleAsync();
        }

        public async Task<Vehicle> GetVehicleByIdAsync(int id)
        {
            return await _VehicleRepository.GetVehicleByIdAsync(id);
        }

        public async Task AddVehicleAsync(VehicleDto VehicleDto)
        {
            await _VehicleRepository.AddVehicleAsync(VehicleDto);
        }

        public async Task UpdateVehicleAsync(int id, Vehicle VehicleDto)
        {
            await _VehicleRepository.UpdateVehicleAsync(id, VehicleDto);
        }

        public async Task DeleteVehicleAsync(int id)
        {
            await _VehicleRepository.DeleteVehicleAsync(id);
        }
    }
}
