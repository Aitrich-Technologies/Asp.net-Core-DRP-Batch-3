using MachineTest.Dto;

namespace MachineTest.Interface
{
    public interface IbookingService
    {
        Task BookTourAsync(Guid userId, BookingDto bookingDto);
        Task<List<BookingDto>> GetMyBookingsAsync(Guid userId);
        Task CancelBookingAsync(Guid bookingId);

    }
}
