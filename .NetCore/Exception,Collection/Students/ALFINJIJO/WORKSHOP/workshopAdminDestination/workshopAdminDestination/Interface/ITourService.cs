using System;
using System.Collections.Generic;
using System.Text;
using workshopAdminDestination.Models;

namespace workshopAdminDestination.Interface
{
    public interface ITourService
    {
        void AddTour(Tour tour);
        List<Tour> GetTours();
    }

}