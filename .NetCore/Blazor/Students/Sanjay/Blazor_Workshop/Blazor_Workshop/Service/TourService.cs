using AutoMapper;
using Blazor_Workshop.Dto;
using Blazor_Workshop.Interface;
using Blazor_Workshop.Models;

namespace Blazor_Workshop.Service
{
    public class TourService : ITourService
    {
        private readonly ITourRepository _repository;

        private readonly IMapper _mapper;

        public TourService(ITourRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateTourAsync(Tour tour)
        {
            // Assign GUID
            tour.Id = Guid.NewGuid();

            await _repository.AddTourAsync(tour);
        }
        public async Task<List<TourDto>> GetAllToursAsync()
        {
            var tours = await _repository.GetAllToursAsync();
            return _mapper.Map<List<TourDto>>(tours);
        }
    }
}
