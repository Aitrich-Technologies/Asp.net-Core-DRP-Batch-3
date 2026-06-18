using AutoMapper;
using MachineTest.Interface;
using MachineTest.Models;
using MachineTest.Dto;
using Microsoft.EntityFrameworkCore;

namespace MachineTest.Repository
{
    public class PackageRepository : IPackageRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PackageRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Packages>> GetAllPackageAsync()
        {
            var packages = await _context.Packages.ToListAsync();
            return packages;
        }

        public async Task<Packages> GetPackageByIdAsync(int id)
        {
            var package = await _context.Packages.FindAsync(id);
            return _mapper.Map<Packages>(package);
        }

        public async Task AddPackageAsync(PackageDto tourDto)
        {
            var package = _mapper.Map<Packages>(tourDto);
            _context.Packages.Add(package);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePackageAsync(int id, Packages packageDto)
        {
            var existingPackage = await _context.Packages.FindAsync(id);
            if (existingPackage == null) return;

            _context.Entry(existingPackage).State = EntityState.Detached; 

            var updatedPackage = _mapper.Map<Packages>(packageDto);
            updatedPackage.Id = id; 

            _context.Packages.Attach(updatedPackage);
            _context.Entry(updatedPackage).State = EntityState.Modified; 

            await _context.SaveChangesAsync();
        }

        public async Task DeletePackageAsync(int id)
        {
            var package = await _context.Packages.FindAsync(id);
            if (package != null)
            {
                _context.Packages.Remove(package);
                await _context.SaveChangesAsync();
            }
        }
    }
}
