using Exercise1.Models;

namespace Exercise1.Interface
{
    public interface ITourRepository
    {
        List<Tour> GetAll();

        Tour GetById(int id);

        void Add(Tour tour);

        void Update(Tour tour);

        void Delete(int id);
    }
}
