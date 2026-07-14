
using MachineTest.Models;

namespace MachineTest.Interface
{
    public interface IBookingRepository
    {
        Task AddBookingAsync(Booking booking);
        Task<List<Booking>> GetBookingsByUserAsync(Guid userId);
        Task<Booking?> GetBookingByIdAsync(Guid bookingId);
        Task UpdateBookingAsync(Booking booking);
    }
}
