using AutoMapper;
using BlazorWorkshop2.Dto;
using BlazorWorkshop2.Interface;
using BlazorWorkshop2.Model;

namespace BlazorWorkshop2.Service
{
    public class DestinationService :IDestinationService

    {
        private readonly IDestinationRepository _destinationRepository;
        private readonly IMapper _mapper;
        public DestinationService(IDestinationRepository destinationRepository, IMapper mapper)
        {
            _destinationRepository = destinationRepository;
            _mapper = mapper;
        }
        public async Task AddAsync(DestinationDto dto)
        {
          
            var dest = _mapper.Map<Destination>(dto);
            await _destinationRepository.AddAsync(dest);

        }

        public async Task<List<DestinationDto>> GetAllAsync()
        {
            var data = await _destinationRepository.GetAllAsync();
            return _mapper.Map<List<DestinationDto>>(data);
          
        }
        public async Task<DestinationDto> GetByIdAsync(int id)
        {
            var x = await _destinationRepository.GetByIdAsync(id);

            if (x == null) return null;

            return new DestinationDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl
            };
        }
        public async Task UpdateAsync(DestinationDto dto)
        {
            var entity = new Destination
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                ImageUrl = dto.ImageUrl
            };

            await _destinationRepository.UpdateAsync(entity);
        }
        public async Task DeleteAsync(int id)
        {
            await _destinationRepository.DeleteAsync(id);
        }
    }
}
