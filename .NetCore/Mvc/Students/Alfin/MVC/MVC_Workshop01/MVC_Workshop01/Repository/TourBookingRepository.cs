using Microsoft.EntityFrameworkCore;
using MVC_Workshop01.Interface;
using MVC_Workshop01.Models;

namespace MVC_Workshop01.Repository
{
    public class TourBookingRepository : ITourBookingRepository
    {
        private readonly AppDbContext _context;

        public TourBookingRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TourBookingForm>> GetAllBookingAsync()
        {
            return await _context.TourBookingForm.ToListAsync();
        }

        //public async Task<bool> IsAlreadyBooked(Guid userId)
        //{
        //    return await _context.TourBookingForm.AnyAsync(x => x.UserId == userId);
        //}

        public async Task<TourBookingForm> GetByIdAsync(Guid Id)
            => await _context.TourBookingForm.FindAsync(Id);

        //public async Task<TourBookingForm> GetAllBookingAsync(Guid Id)
        //    => await _context.TourBookingForm.FindAsync(Id);

        public async Task<TourBookingForm> AddAsync(TourBookingForm booking)
        { 
         _context.TourBookingForm.Add(booking);
            await _context.SaveChangesAsync();
            return booking;
        }
        public async Task<TourBookingForm> UpdateAsync(TourBookingForm booking)
        {
            _context.TourBookingForm.Update(booking);
            await _context.SaveChangesAsync();
            return booking;
        }
        public async Task DeleteAsync(Guid id)
        {
            var booking = await _context.TourBookingForm.FindAsync(id);

            if (booking != null)
            {
                _context.TourBookingForm.Remove(booking);
                await _context.SaveChangesAsync();
            }
        }
    }
}
