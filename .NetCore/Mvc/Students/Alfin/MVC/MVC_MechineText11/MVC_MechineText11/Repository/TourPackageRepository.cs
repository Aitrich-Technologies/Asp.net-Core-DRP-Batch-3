using Microsoft.EntityFrameworkCore;
using MVC_MechineText11.Interface;
using MVC_MechineText11.Models;

namespace MVC_MechineText11.Repository
{
    public class TourPackageRepository : ITourPackageRepository
    {
        private readonly AppDbContext _context;

        public TourPackageRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TourPackage>> GetAllAsync()
        {
            return await _context.TourPackages
                .Include(x => x.Agency)
                .ToListAsync();
        }

        public async Task<TourPackage?> GetByIdAsync(Guid id)
        {
            return await _context.TourPackages
                .Include(x => x.Agency)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(TourPackage package)
        {
            await _context.TourPackages.AddAsync(package);
        }

        public Task UpdateAsync(TourPackage package)
        {
            _context.TourPackages.Update(package);
            return Task.CompletedTask;
        }

        public async Task DeleteAsync(Guid id)
        {
            var package = await GetByIdAsync(id);

            if (package != null)
            {
                _context.TourPackages.Remove(package);
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
