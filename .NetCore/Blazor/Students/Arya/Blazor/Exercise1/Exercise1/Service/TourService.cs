using AutoMapper;
using Exercise1.Dto;
using Exercise1.Interface;
using Exercise1.Models;

namespace Exercise1.Service
{
    public class TourService : ITourService
    {
        private readonly ITourRepository _repository;
        private readonly IMapper _mapper;

        public TourService(ITourRepository repository,
                           IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<Tour> GetAll()
        {
            return _repository.GetAll();
        }

        public Tour GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Add(TourDto tourDto)
        {
            var tour = _mapper.Map<Tour>(tourDto);

            _repository.Add(tour);
        }

        public void Update(Tour tour)
        {
            _repository.Update(tour);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}