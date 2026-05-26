using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using WEH1.Models;

namespace WEH1.Interface
{
    public interface ITourRepository
    {
        void AddTour(Tour tour);
        List<Tour> GetTours();
    }
}
