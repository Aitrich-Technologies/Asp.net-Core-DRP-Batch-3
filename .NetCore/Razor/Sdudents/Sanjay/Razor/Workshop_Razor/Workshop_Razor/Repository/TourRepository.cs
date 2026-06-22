using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Workshop_Razor.Dto;
using Workshop_Razor.Interface;
using Workshop_Razor.Models;

namespace Workshop_Razor.Repository
{
    public class TourRepository : ITourRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public TourRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Tours>> GetAllTourAsync()
        {
            var tours = await _context.Tours.ToListAsync();
            return tours;
        }

        public async Task<Tours> GetTourByIdAsync(int id)
        {
            var tour = await _context.Tours.FindAsync(id);
            return _mapper.Map<Tours>(tour);
        }

        public async Task AddTourAsync(TourDto tourDto)
        {
            var tour = _mapper.Map<Tours>(tourDto);
            _context.Tours.Add(tour);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTourAsync(int id, Tours tourDto)
        {
            var existingTour = await _context.Tours.FindAsync(id);
            if (existingTour == null) return; // Ensure job exists

            _context.Entry(existingTour).State = EntityState.Detached; // Detach old instance

            var updatedTour = _mapper.Map<Tours>(tourDto);
            updatedTour.Id = id; // Ensure the ID remains the same

            _context.Tours.Attach(updatedTour); // Attach the new instance
            _context.Entry(updatedTour).State = EntityState.Modified; // Mark as modified

            await _context.SaveChangesAsync();
        }

        public async Task DeleteTourAsync(int id)
        {
            var tour = await _context.Tours.FindAsync(id);
            if (tour != null)
            {
                _context.Tours.Remove(tour);
                await _context.SaveChangesAsync();
            }
        }
    }
}
