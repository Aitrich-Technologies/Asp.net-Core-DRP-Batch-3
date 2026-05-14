using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise2.Interface;
using Excercise2.Models;

namespace Excercise2.Repository
{
  public class TourRepository:ITourRepository
    {
        private List<Tour> tours = new List<Tour>();

        public void AddTour(Tour tour)
        {
            tours.Add(tour);
        }

        public List<Tour> GetTours()
        {
            return tours;
        }
    }
}

