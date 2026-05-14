using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise3.Models;

namespace Excercise3.Interface
{
    public interface ITourProvider
    {
        List<Tour> GetAllTours();

        void AddTour(Tour tour);
    }
}

