using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEH1.Models;

namespace WEH1.Interface
{
    public interface ITourService
    {
        void AddTour(Tour tour);
        List<Tour> GetTours();
    }
}
