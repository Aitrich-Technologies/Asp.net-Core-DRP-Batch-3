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

            public async Task<Tour> AddAsync(Tour tour)
            {
                await _context.Tours.AddAsync(tour);
                await _context.SaveChangesAsync();

                return tour;
            }

            public async Task<List<Tour>> GetAllAsync()
            {
                return await _context.Tours.AsNoTracking().ToListAsync();
            }

            public async Task<Tour?> GetByIdAsync(Guid id)
            {
                return await _context.Tours.AsNoTracking().FirstOrDefaultAsync(t => t.Id == id);
            }
        }
    }

