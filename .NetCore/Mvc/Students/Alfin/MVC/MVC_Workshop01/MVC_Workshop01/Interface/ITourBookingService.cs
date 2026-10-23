using MVC_Workshop01.Dto;

namespace MVC_Workshop01.Interface
{
    public interface ITourBookingService
    {
        Task<List<TourBookingDto>> GetAllBookingAsync();
        Task<TourBookingDto?> GetByIdAsync(Guid Id);
        Task<TourBookingDto> CreateAsync(CreateBookingDto dto, Guid Id);
        Task UpdateAsync(TourBookingDto dto);
        Task DeleteAsync(Guid id);

    }
}
