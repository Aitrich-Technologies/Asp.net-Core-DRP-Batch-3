using AutoMapper;
using Workshop.Dto;
using Workshop.Interface;
using Workshop.Models;

namespace Workshop.Service
{
    public class DestinationService : IDestinationService
    {
        private readonly IDestinationRepository _destiRepository;
        private readonly IMapper _mapper;

        public DestinationService(
            IDestinationRepository destiRepository,
            IMapper mapper)
        {
            _destiRepository = destiRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddDestiAsync(DestinationDto destinationDto)
        {
            var desti = _mapper.Map<Destination>(destinationDto);
            await _destiRepository.AddAsync(desti);
            return true;
        }

        public async Task<bool> DeleteDestiAsync(int Id)
        {
            await _destiRepository.DeleteAsync(Id);
            return true;
        }

        public async Task<List<DestinationDto>> GetAllAsync()
        {
            var destiList = await _destiRepository.GetAllAsync();
            return _mapper.Map<List<DestinationDto>>(destiList);
        }

        public async Task<DestinationDto> GetByIdAsync(int Id)
        {
            var desti = await _destiRepository.GetByIdAsync(Id);

            if (desti == null)
                return null;

            return _mapper.Map<DestinationDto>(desti);
        }

        public async Task<bool> UpdateDestiAsync(DestinationDto destinationDto)
        {
            var desti = await _destiRepository.GetByIdAsync(destinationDto.Id);

            if (desti == null)
                return false;

            _mapper.Map(destinationDto, desti);
            await _destiRepository.UpdateAsync(desti);

            return true;
        }
    }
}