using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin_Destination.Interface;
using Admin_Destination.Models;

namespace Admin_Destination.Manager
{
  public class TourManager:ITourService
    {
        private List<Tour> tours = new List<Tour>();
        int count = 0;
        
        public void AddTour(Tour tour)
        {
            tour.Id = tours.Count + 1;
            tours.Add(tour);
        }

        public List<Tour> GetTours()
        {
            return tours;
        }


        public Tour GetTourById(int id)
        {
            return tours.FirstOrDefault(t => t.Id == id);
        }


    }
}
    

