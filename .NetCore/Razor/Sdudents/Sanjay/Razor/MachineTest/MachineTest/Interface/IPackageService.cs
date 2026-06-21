using MachineTest.Models;    
using MachineTest.Dto;
namespace MachineTest.Interface
{
    public interface IPackageService
    {
        public Task<List<Packages>> GetAllPackageAsync();

        public Task<Packages> GetPackageByIdAsync(int id);


        public Task AddPackageAsync(PackageDto packageDto);


        public Task UpdatePackageAsync(int id, Packages packageDto);

        public Task DeletePackageAsync(int id);
    }
}
