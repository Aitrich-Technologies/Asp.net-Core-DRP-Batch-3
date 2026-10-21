using MVC_Workshop01.Models;

namespace MVC_Workshop01.Interface
{
    public interface ITourBookingRepository
    {
        Task<List<TourBookingForm>> GetAllBookingAsync();
        Task<TourBookingForm> GetByIdAsync(Guid Id);

        Task<TourBookingForm> AddAsync(TourBookingForm booking);
        Task<TourBookingForm> UpdateAsync(TourBookingForm booking);
        Task DeleteAsync(Guid id);


    }
}
