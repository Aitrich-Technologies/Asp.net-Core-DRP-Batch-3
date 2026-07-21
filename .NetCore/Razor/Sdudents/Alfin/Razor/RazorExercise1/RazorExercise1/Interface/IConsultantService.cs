using RazorExercise1.Dto;
using RazorExercise1.Model;

namespace RazorExercise1.Interface
{
    public interface IConsultantService
    {
        public Task<List<Consultants>> GetAllConsultantAsync(int regsterId);

        public Task<Consultants> GetConsultantByIdAsync(int id);


        public Task AddConsultantAsync(ConsultantDto consultantDto, int regsterId);


        public Task UpdateConsultantAsync(int id, Consultants consultantDto);

        public Task DeleteConsultantAsync(int id, int regsterId);
        public Task<int> GetTotalConsultantsByUserAsync(int registerId);
    }
}
