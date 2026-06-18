using Exercise.Dto;
using Exercise.Models;

namespace Exercise.Interface
{
    public interface IConsultantRepository
    {
        public Task<List<Consultants>> GetAllConsultantAsync(int regsterId);

        public Task<Consultants> GetConsultantByIdAsync(int id);


        public Task AddConsultantAsync(ConsultantDto consultantDto, int regsterId);


        public Task UpdateConsultantAsync(int id, Consultants consultantDto);

        public Task DeleteConsultantAsync(int id, int regsterId);
        public Task<int> GetTotalConsultantsByUserAsync(int registerId);

    }
}
