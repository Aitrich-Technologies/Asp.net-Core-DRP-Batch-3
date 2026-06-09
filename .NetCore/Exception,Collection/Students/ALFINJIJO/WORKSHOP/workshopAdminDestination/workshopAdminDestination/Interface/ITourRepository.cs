using System;
using System.Collections.Generic;
using System.Text;
using workshopAdminDestination.Models;

namespace workshopAdminDestination.Interface
{
    public interface ITourRepository
    {
        void AddTour(Tour tour);
        List<Tour> GetTours();
    }

}
