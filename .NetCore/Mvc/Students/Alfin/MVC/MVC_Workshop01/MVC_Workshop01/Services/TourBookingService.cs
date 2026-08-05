using AutoMapper;
using MVC_Workshop01.Dto;
using MVC_Workshop01.Interface;
using MVC_Workshop01.Models;

namespace MVC_Workshop01.Services
{
    public class TourBookingService : ITourBookingService
    {
        private readonly ITourBookingRepository _repository;
        private readonly IMapper _mapper;

        public TourBookingService(ITourBookingRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //public async Task<bool> IsAlreadyBooked(Guid userId)
        //{
        //    return await _repository.IsAlreadyBooked(userId);

        //}
        public async Task<List<TourBookingDto>> GetAllBookingAsync()
        {
            var tours = await _repository.GetAllBookingAsync();
            return _mapper.Map<List<TourBookingDto>>(tours);
        }

        public async Task<TourBookingDto?> GetByIdAsync(Guid id)
        {
            var booking = await _repository.GetByIdAsync(id);
            return _mapper.Map<TourBookingDto?>(booking);
        }
        //public async Task<TourBookingDto?> GetByIdBookingAsync(Guid id)
        //{
        //    var tour = await _repository.GetByIdAsync(id);
        //    return _mapper.Map<TourBookingDto?>(tour);
        //}
        public async Task<TourBookingDto> CreateAsync(CreateBookingDto dto, Guid id)
        {
            //dto.TourId = id;

            var entity = _mapper.Map<TourBookingForm>(dto);
            var booking = await _repository.AddAsync(entity);
            return _mapper.Map<TourBookingDto>(booking);

        }
        public async Task UpdateAsync(TourBookingDto dto)
        {
            var booking = await _repository.GetByIdAsync(dto.Id);

            booking.FirstName = dto.FirstName;
            booking.LastName = dto.LastName;
            booking.Gender = dto.Gender;
            booking.Dob = dto.Dob;
            booking.Citizenship = dto.Citizenship;
            booking.PassportNumber = dto.PassportNumber;
            booking.IssueDate = dto.IssueDate;
            booking.ExpiryDate = dto.ExpiryDate;
            booking.PlaceOfBirth = dto.PlaceOfBirth;
            booking.LeadPassenger = dto.LeadPassenger;
            //booking.ParticipantType = dto.ParticipantType;
            //booking.Status = dto.Status;

            await _repository.UpdateAsync(booking);
        }
        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
