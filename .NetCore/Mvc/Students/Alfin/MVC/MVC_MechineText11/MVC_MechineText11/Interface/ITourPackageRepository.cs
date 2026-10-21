using MVC_MechineText11.Models;

namespace MVC_MechineText11.Interface
{
    public interface ITourPackageRepository
    {
        Task<List<TourPackage>> GetAllAsync();
        Task<TourPackage?> GetByIdAsync(Guid id);
        Task AddAsync(TourPackage package);
        Task UpdateAsync(TourPackage package);
        Task DeleteAsync(Guid id);
        Task SaveAsync();
    }
}
