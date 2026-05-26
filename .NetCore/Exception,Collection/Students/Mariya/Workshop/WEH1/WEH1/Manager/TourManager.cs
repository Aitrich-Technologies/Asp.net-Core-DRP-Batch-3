using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WEH1.Interface;
using WEH1.Models;

namespace WEH1.Manager
{
    public class TourManager:ITourService
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
