using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin_Destination.Models;

namespace Admin_Destination.Interface
{
    public interface ITourService
    {
        void AddTour(Tour tour);
        List<Tour> GetTours();

      
    }
}

