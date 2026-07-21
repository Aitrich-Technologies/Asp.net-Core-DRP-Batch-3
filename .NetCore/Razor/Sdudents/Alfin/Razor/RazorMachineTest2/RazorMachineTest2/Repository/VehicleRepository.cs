using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RazorMachineTest2.Dtos;
using RazorMachineTest2.Interface;
using RazorMachineTest2.Models;

namespace RazorMachineTest2.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        //private Vehicle updatedVehicles;

        public VehicleRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Vehicle>> GetAllVehicleAsync()
        {
            var Vehicle = await _context.Vehicle.ToListAsync();
            return Vehicle;
        }

        public async Task<Vehicle> GetVehicleByIdAsync(int id)
        {
            var Vehicle = await _context.Vehicle.FindAsync(id);
            return _mapper.Map<Vehicle>(Vehicle);
        }

        public async Task AddVehicleAsync(VehicleDto VehicleDto)
        {
            var Vehicle = _mapper.Map<Vehicle>(VehicleDto);
            _context.Vehicle.Add(Vehicle);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateVehicleAsync(int id, Vehicle VehicleDto)
        {
            var existingVehicle = await _context.Vehicle.FindAsync(id);
            if (existingVehicle == null) return;

            _context.Entry(existingVehicle).State = EntityState.Detached;

            var updatedVehicle = _mapper.Map<Vehicle>(VehicleDto);
            updatedVehicle.Id = id;

            _context.Vehicle.Attach(updatedVehicle);
            _context.Entry(updatedVehicle).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteVehicleAsync(int id)
        {
            var package = await _context.Vehicle.FindAsync(id);

            if (package != null)
            {
                _context.Vehicle.Remove(package);
                await _context.SaveChangesAsync();
            }
        }
    }
}
