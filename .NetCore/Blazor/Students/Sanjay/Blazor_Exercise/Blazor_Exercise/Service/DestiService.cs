using AutoMapper;
using Blazor_Exercise.Dto;
using Blazor_Exercise.Interface;
using Blazor_Exercise.Models;


namespace Blazor_Exercise.Service
{
    public class DestiService : IDestiService
    {
        private readonly IDestiRepository _destiRepository;
        private readonly IMapper _mapper;

        public DestiService(IDestiRepository destiRepository,IMapper mapper)
        {
            _destiRepository = destiRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddDestiAsync(DestinationnDto destinationDto)
        {
            var desti = _mapper.Map<Destinationn>(destinationDto);
            await _destiRepository.AddAsync(desti);
            return true;
        }

        public async Task<bool> DeleteDestiAsync(int id)
        {
            await _destiRepository.DeleteAsync(id);
            return true;
        }

        public async Task<List<DestinationnDto>> GetAllAsync()
        {
            var destiList = await _destiRepository.GetAllAsync();
            return _mapper.Map<List<DestinationnDto>>(destiList);
        }

        public async Task<DestinationnDto> GetByIdAsync(int id)
        {
            var desti = await _destiRepository.GetByIdAsync(id);

            if (desti == null)
                return null;

            return _mapper.Map<DestinationnDto>(desti);
        }

        public async Task<bool> UpdateDestiAsync(DestinationnDto destinationDto)
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
