using Exercise1.Interface;
using Exercise1.Models;

namespace Exercise1.Repository
{
    public class TourRepository : ITourRepository
    {
        private readonly AppDbContext _context;

        public TourRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Tour> GetAll()
        {
            return _context.Tours.ToList();
        }

        public Tour GetById(int id)
        {
            return _context.Tours.Find(id);
        }

        public void Add(Tour tour)
        {
            _context.Tours.Add(tour);
            _context.SaveChanges();
        }

        public void Update(Tour tour)
        {
            _context.Tours.Update(tour);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _context.Tours.Find(id);

            if (data != null)
            {
                _context.Tours.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}