using AutoMapper;
using BlazorExercise2.Dto;
using BlazorExercise2.Interface;
using BlazorExercise2.Model;
using BlazorExercise2.Repository;

namespace BlazorExercise2.Service
{
    public class DestService :IDestService
    {
        private readonly IDestRepository _destRepository;
        private readonly IMapper _mapper;

        public DestService(IDestRepository destRepository, IMapper mapper)
        {
            _destRepository = destRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddDestiAsync(DestinationDto destinationDto)
        {
            var desti = _mapper.Map<Destination>(destinationDto);
            await _destRepository.AddAsync(desti);
            return true;
        }

        public async Task<bool> DeleteDestiAsync(int id)
        {
            await _destRepository.DeleteAsync(id);
            return true;
        }

        public async Task<List<DestinationDto>> GetAllAsync()
        {
            var destiList = await _destRepository.GetAllAsync();
            return _mapper.Map<List<DestinationDto>>(destiList);
        }

        public async Task<DestinationDto> GetByIdAsync(int id)
        {
            var desti = await _destRepository.GetByIdAsync(id);

            if (desti == null)
                return null;

            return _mapper.Map<DestinationDto>(desti);
        }

        public async Task<bool> UpdateDestiAsync(DestinationDto destinationDto)
        {
            var desti = await _destRepository.GetByIdAsync(destinationDto.Id);

            if (desti == null)
                return false;

            _mapper.Map(destinationDto, desti);
            await _destRepository.UpdateAsync(desti);

            return true;
        }
    }
}
