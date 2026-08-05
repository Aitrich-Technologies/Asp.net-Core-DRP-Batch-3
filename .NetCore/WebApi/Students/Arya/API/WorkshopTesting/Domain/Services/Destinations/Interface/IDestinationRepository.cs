using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Destinations.Interface
{
    public interface IDestinationRepository
    {
        Task<IEnumerable<Destination>> GetAllAsync();
        Task<Destination?> GetByIdAsync(Guid id);
        Task AddAsync(Destination entity);
        Task<bool> UpdateAsync(Destination entity);
        Task<bool> DeleteAsync(Guid id);
    }
}
