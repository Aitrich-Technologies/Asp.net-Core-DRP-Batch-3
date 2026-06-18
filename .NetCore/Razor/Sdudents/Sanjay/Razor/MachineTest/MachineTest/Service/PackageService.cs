using MachineTest.Interface;
using MachineTest.Models;
using MachineTest.Dto;
using MachineTest.Repository;
namespace MachineTest.Service
{
    public class PackageService : IPackageService
    {
        private readonly IPackageRepository _packageRepository;

        public PackageService(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }

        public async Task<List<Packages>> GetAllPackageAsync()
        {
            return await _packageRepository.GetAllPackageAsync();
        }

        public async Task<Packages> GetPackageByIdAsync(int id)
        {
            return await _packageRepository.GetPackageByIdAsync(id);
        }

        public async Task AddPackageAsync(PackageDto packageDto)
        {
            await _packageRepository.AddPackageAsync(packageDto);
        }

        public async Task UpdatePackageAsync(int id, Packages packageDto)
        {
            await _packageRepository.UpdatePackageAsync(id, packageDto);
        }

        public async Task DeletePackageAsync(int id)
        {
            await _packageRepository.DeletePackageAsync(id);
        }
    }
}

