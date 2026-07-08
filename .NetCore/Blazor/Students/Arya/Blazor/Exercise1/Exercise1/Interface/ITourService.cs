using Exercise1.Dto;
using Exercise1.Models;

namespace Exercise1.Interface
{
    public interface ITourService
    {
        List<Tour> GetAll();

        Tour GetById(int id);

        void Add(TourDto tourDto);

        void Update(Tour tour);

        void Delete(int id);
    }
}
