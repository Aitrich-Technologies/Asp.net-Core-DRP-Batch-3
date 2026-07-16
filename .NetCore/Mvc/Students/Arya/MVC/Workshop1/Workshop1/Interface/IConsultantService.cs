using Workshop1.Dto;

namespace Workshop1.Interface
{
    public interface IConsultantService
    {
        Task<List<ConsultantListDto>> GetAllAsync();
        Task<(bool Success, string Error)> CreateAsync(CreateConsultantDto dto);
        Task<ConsultantDetailsDto> GetByIdAsync(Guid id);

    }
}
