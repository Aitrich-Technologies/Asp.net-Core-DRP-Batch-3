using AutoMapper;
using MachineTest.DTOs;
using MachineTest.Interface;
using MachineTest.Models;

namespace MachineTest.Services
{
    public class TourService : ITourService
    {
        private readonly ITourRepository _tourRepository;
        private readonly IMapper _mapper;

        public TourService(ITourRepository tourRepository,IMapper mapper)
        {
            _tourRepository = tourRepository;
            _mapper = mapper;
        }

        public async Task<TourResponseDto> AddAsync(TourCreateDto dto, Guid createdBy)
        {
            var tour = _mapper.Map<Tour>(dto);

            tour.Id = Guid.NewGuid();
            tour.CreatedBy = createdBy;

            var savedTour = await _tourRepository.AddAsync(tour);

            return _mapper.Map<TourResponseDto>(savedTour);
        }

        public async Task<List<TourResponseDto>> GetAllAsync()
        {
            var tours = await _tourRepository.GetAllAsync();

            return _mapper.Map<List<TourResponseDto>>(tours);
        }

        public async Task<TourResponseDto?> GetByIdAsync(Guid id)
        {
            var tour = await _tourRepository.GetByIdAsync(id);

            if (tour == null)
                return null;

            return _mapper.Map<TourResponseDto>(tour);
        }
    }
}
