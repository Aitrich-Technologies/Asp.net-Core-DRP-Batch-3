using MachineTest.Interface;
using MachineTest.Models;
using Microsoft.EntityFrameworkCore;

namespace MachineTest.Repository
{
    public class TourRepository : ITourRepository
    {
        private readonly AppDbContext _context;

        public TourRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tour>> GetAllToursAsync()
        {
            return await _context.Tours.ToListAsync();
        }

        public async Task<Tour?> GetTourByIdAsync(Guid id)
        {
            return await _context.Tours.FirstOrDefaultAsync(x => x.TourId == id);
        }

        public async Task AddTourAsync(Tour tour)
        {
            await _context.Tours.AddAsync(tour);
            await _context.SaveChangesAsync();
        }
    }
}