using AutoMapper;
using BlazorWorkshop2.Dto;
using BlazorWorkshop2.Interface;
using BlazorWorkshop2.Model;

namespace BlazorWorkshop2.Service
{
    public class TourService : ITourService
    {
        private readonly ITourRepository _repo;
        private readonly IMapper _mapper;

        public TourService(ITourRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task AddAsync(TourDto dto)
        {
            var entity = _mapper.Map<Tour>(dto);
            await _repo.AddAsync(entity);
            //throw new NotImplementedException();
        }

        public async Task<List<TourDto>> GetAllAsync()
        {
            var data = await _repo.GetAllAsync();
            return _mapper.Map<List<TourDto>>(data);
            //throw new NotImplementedException();
        }
    }
}
