using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise2.Models;

namespace Excercise2.Interface
{
    public interface ITourRepository
    {
        void AddTour(Tour tour);

        List<Tour> GetTours();
    }
}
