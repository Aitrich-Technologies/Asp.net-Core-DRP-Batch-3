using AutoMapper;
using Exercise3.Dto;
using Exercise3.Interface;
using Exercise3.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercise3.Service
{
    public class DestinationService:IDestinationService
    {
        private readonly IDestinationRepository _repository;
        private readonly IMapper _mapper;

        public DestinationService(
            IDestinationRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<DestinationDto>> GetAll()
        {
            var destinations =
                await _repository.GetAll();

            return _mapper.Map<List<DestinationDto>>
                (destinations);
        }

        public async Task<DestinationDto?> GetById(int id)
        {
            var destination =
                await _repository.GetById(id);

            return _mapper.Map<DestinationDto>
                (destination);
        }

        public async Task Add(
            DestinationDto destinationDto)
        {
            var destination =
                _mapper.Map<Destination>(destinationDto);

            await _repository.Add(destination);

            await _repository.Save();
        }

        public async Task Update(
            DestinationDto destinationDto)
        {
            var destination =
                _mapper.Map<Destination>(destinationDto);

            _repository.Update(destination);

            await _repository.Save();
        }

        public async Task Delete(int id)
        {
            var destination =
                await _repository.GetById(id);

            if (destination != null)
            {
                _repository.Delete(destination);

                await _repository.Save();
            }
        }
    }
}
