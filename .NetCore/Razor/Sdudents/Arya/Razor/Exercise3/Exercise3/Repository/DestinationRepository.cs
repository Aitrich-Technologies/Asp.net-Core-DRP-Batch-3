using Exercise3.Interface;
using Exercise3.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercise3.Repository
{
    public class DestinationRepository : IDestinationRepository
    {
        private readonly AppDbContext _context;

        public DestinationRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Destination>> GetAll()
        {
            return await _context.Destinations.ToListAsync();
        }

        public async Task<Destination?> GetById(int id)
        {
            return await _context.Destinations.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Add(Destination destination)
        {
            await _context.Destinations.AddAsync(destination);
        }

        public void Update(Destination destination)
        {
            _context.Destinations.Update(destination);
        }

        public void Delete(Destination destination)
        {
            _context.Destinations.Remove(destination);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}