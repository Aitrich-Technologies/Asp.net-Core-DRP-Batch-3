using ExerciseException1.Interface;
using ExerciseException1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseException1.Repository
{
    public class TourRepository : ITourRepository
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
