using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise1.Models;

namespace Excercise1.Repository
{
    public class TourRepository
    {
        private List<Tour> tours = new List<Tour>();

        public TourRepository()
        {
            // Hardcoded Tours
            tours.Add(new Tour("Paris", 5, 50000) { Id = 1 });
            tours.Add(new Tour("Dubai", 4, 40000) { Id = 2 });
            tours.Add(new Tour("Maldives", 6, 75000) { Id = 3 });
        }

        public List<Tour> GetAllTours()
        {
            return tours;
        }
    }
}

