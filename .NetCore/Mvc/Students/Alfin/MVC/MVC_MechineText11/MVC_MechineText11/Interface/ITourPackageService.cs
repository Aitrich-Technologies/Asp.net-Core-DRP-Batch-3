using MVC_MechineText11.Dto;
using MVC_MechineText11.Models;

namespace MVC_MechineText11.Interface
{
    public interface ITourPackageService
    {
        Task<List<TourPackageDto>> GetAllAsync();
        Task<TourPackageDto?> GetByIdAsync(Guid id);
        Task CreateAsync(TourPackageDto dto, Guid agencyId);
        Task UpdateAsync(TourPackageDto package);
        Task DeleteAsync(Guid id);
       
    }
}
