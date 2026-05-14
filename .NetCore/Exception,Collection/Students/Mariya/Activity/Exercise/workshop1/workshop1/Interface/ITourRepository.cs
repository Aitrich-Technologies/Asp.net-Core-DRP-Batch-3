using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop1.Models;

namespace workshop1.Interface
{
    public interface ITourRepository
    {
        void AddTour(Tour tour);
        Tour[] GetAllTours();
        Tour GetTourById(int id);
    }
}
