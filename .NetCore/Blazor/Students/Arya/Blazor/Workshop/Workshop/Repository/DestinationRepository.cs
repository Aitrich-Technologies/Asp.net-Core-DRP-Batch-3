using Microsoft.EntityFrameworkCore;
using Workshop.Interface;
using Workshop.Models;

namespace Workshop.Repository
{
    public class DestinationRepository:IDestinationRepository
    {
        private readonly AppDbContext _context;

        public DestinationRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Destination destination)
        {
            _context.Destinations.Add(destination);
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

        public async Task<Destination?> GetByIdAsync(int destiId)
        {
            return await _context.Destinations.FindAsync(destiId);
        }


        public async Task<List<Destination>> GetAllAsync()
        {
            return await _context.Destinations.ToListAsync();
        }

        public async Task UpdateAsync(Destination destination)
        {
            _context.Destinations.Update(destination);
            await _context.SaveChangesAsync();
        }


    }
}
