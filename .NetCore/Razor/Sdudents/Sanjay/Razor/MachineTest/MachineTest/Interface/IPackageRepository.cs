using MachineTest.Dto;
using MachineTest.Models;

namespace MachineTest.Interface
{
    public interface IPackageRepository
    {

        public Task<Packages> GetPackageByIdAsync(int id);

        Task<List<Packages>> GetAllPackageAsync();
        public Task AddPackageAsync(PackageDto packageDto);


        public Task UpdatePackageAsync(int id, Packages packageDto);

        public Task DeletePackageAsync(int id);
    }
}
