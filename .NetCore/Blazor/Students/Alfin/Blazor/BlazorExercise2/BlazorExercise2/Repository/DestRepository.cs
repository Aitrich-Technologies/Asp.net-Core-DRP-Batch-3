using BlazorExercise2.Interface;
using BlazorExercise2.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorExercise2.Repository
{
    public class DestRepository :IDestRepository
    {
        private readonly AppDbContext _context;

        public DestRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Destination destination)
        {
            _context.Destinations.Add(destination);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int destId)
        {
            var dest = await _context.Destinations.FindAsync(destId);
            if (dest != null)
            {
                _context.Destinations.Remove(dest);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Destination> GetByIdAsync(int destId)
        {
            return await _context.Destinations.FindAsync(destId);
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
