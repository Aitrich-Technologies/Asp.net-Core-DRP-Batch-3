using AutoMapper;
using MVC_MechineText11.Dto;
using MVC_MechineText11.Interface;
using MVC_MechineText11.Models;

namespace MVC_MechineText11.Service
{
    public class TourPackageService :ITourPackageService
    {
        private readonly ITourPackageRepository _repo;
        private readonly IMapper _mapper;

        public TourPackageService(ITourPackageRepository repo,
                                  IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<TourPackageDto>> GetAllAsync()
        {
            var data = await _repo.GetAllAsync();

            return _mapper.Map<List<TourPackageDto>>(data);
        }

        public async Task<TourPackageDto?> GetByIdAsync(Guid id)
        {
            var package = await _repo.GetByIdAsync(id);

            return _mapper.Map<TourPackageDto>(package);
        }

        public async Task CreateAsync(TourPackageDto dto, Guid agencyId)
        {
            var package = _mapper.Map<TourPackage>(dto);

            package.Id = Guid.NewGuid();

            package.AgencyId = agencyId;

            await _repo.AddAsync(package);
            await _repo.SaveAsync();
        }


        public async Task UpdateAsync(TourPackageDto dto)
        {
            var package = await _repo.GetByIdAsync(dto.Id);

            if (package == null)
            {
                throw new Exception("Tour Package not found.");
            }

            package.PackageName = dto.PackageName;
            package.Destination = dto.Destination;
            package.Price = dto.Price;
            package.Duration = dto.Duration;
            package.Description = dto.Description;

            package.AgencyId = dto.AgencyId;

            await _repo.UpdateAsync(package);
            await _repo.SaveAsync();
        }


        public async Task DeleteAsync(Guid id)
        {
            await _repo.DeleteAsync(id);
            await _repo.SaveAsync();
        }
    }
}
