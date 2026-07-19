using Exercise3.Models;

namespace Exercise3.Interface
{
    public interface IDestinationRepository
    {
        Task<List<Destination>> GetAll();

        Task<Destination?> GetById(int id);

        Task Add(Destination destination);

        void Update(Destination destination);

        void Delete(Destination destination);

        Task Save();
    }
}
