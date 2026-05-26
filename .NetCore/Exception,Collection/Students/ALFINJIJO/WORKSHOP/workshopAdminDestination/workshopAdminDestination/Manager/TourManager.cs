using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using workshopAdminDestination.Interface;
using workshopAdminDestination.Models;

namespace workshopAdminDestination.Manager
{

    public class TourManager : ITourService
    {
        private List<Tour> tours = new List<Tour>();

        public void AddTour(Tour tour)
        {
            tour.Id = tours.Count + 1;
            tours.Add(tour);
        }

        public List<Tour> GetTours()
        {
            return tours;
        }
    }

}

