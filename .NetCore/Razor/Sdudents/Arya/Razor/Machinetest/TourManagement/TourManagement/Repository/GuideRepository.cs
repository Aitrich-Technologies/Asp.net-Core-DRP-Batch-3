using Microsoft.EntityFrameworkCore;
using TourManagement.Interface;
using TourManagement.Models;

namespace TourManagement.Repository
{
    public class GuideRepository : IGuideRepository
    {
        private readonly AppDbContext _context;

        public GuideRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Guide>> GetAllAsync()
        {
            return await _context.Guides.ToListAsync();
        }

        public async Task<Guide?> GetByIdAsync(int id)
        {
            return await _context.Guides.FindAsync(id);
        }

        public async Task AddAsync(Guide guide)
        {
            await _context.Guides.AddAsync(guide);
        }

        public Task UpdateAsync(Guide guide)
        {
            _context.Guides.Update(guide);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Guide guide)
        {
            _context.Guides.Remove(guide);
            return Task.CompletedTask;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}