using Blazor_Exercise.Interface;
using Blazor_Exercise.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Exercise.Repository
{
    public class DestiRepository : IDestiRepository
    {
        private readonly AppDbContext _context;

        public DestiRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Destinationn destinationn)
        {
            _context.Destinations.Add(destinationn);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int destiId)
        {
            var desti = await _context.Destinations.FindAsync(destiId);
            if (desti != null)
            {
                _context.Destinations.Remove(desti);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Destinationn> GetByIdAsync(int destiId)
        {
            return await _context.Destinations.FindAsync(destiId);
        }


        public async Task<List<Destinationn>> GetAllAsync()
        {
            return await _context.Destinations.ToListAsync();
        }

        public async Task UpdateAsync(Destinationn destinationn)
        {
            _context.Destinations.Update(destinationn);
            await _context.SaveChangesAsync();
        }
    }
}
