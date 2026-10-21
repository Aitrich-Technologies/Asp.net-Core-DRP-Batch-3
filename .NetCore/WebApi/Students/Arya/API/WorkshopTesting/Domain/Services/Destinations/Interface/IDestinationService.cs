using Domain.Services.Destinations.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Destinations.Interface
{
    public interface IDestinationService
    {
        Task<IEnumerable<DestinationResponseDto>> GetAllAsync();
        Task<DestinationResponseDto?> GetByIdAsync(Guid id);
        Task<DestinationResponseDto> AddAsync(DestinationDto dto);
        Task<bool> UpdateAsync(Guid id, DestinationDto dto);
        Task<bool> PatchAsync(Guid id, DestinationPatchDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
