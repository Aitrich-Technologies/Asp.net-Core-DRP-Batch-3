using AutoMapper;
using MachineTest.Dto;
using MachineTest.Interface;
using MachineTest.Models;

namespace MachineTest.Service
{
    public class TourService:ITourService
    {
        private readonly ITourRepository _tourRepository;
        private readonly IMapper _mapper;

        public TourService(ITourRepository tourRepository, IMapper mapper)
        {
            _tourRepository = tourRepository;
            _mapper = mapper;
        }

        public async Task<List<TourDto>> GetAllToursAsync()
        {
            var tours = await _tourRepository.GetAllToursAsync();
            return _mapper.Map<List<TourDto>>(tours);
        }
        public async Task AddTourAsync(TourDto tourDto)
        {
            var tour = _mapper.Map<Tour>(tourDto);
            await _tourRepository.AddTourAsync(tour);
        }

        public async Task<TourDto?> GetTourByIdAsync(Guid id)
        {
            var tour = await _tourRepository.GetTourByIdAsync(id);

            if (tour == null)
            {
                return null;
            }

            return _mapper.Map<TourDto>(tour);
        }
    }
}
