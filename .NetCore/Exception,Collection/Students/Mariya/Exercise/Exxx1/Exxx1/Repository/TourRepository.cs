using Exxx1.Interface;
using Exxx1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exxx1.Repository
{
    public class TourRepository:ITourRepository
    {

        private List<Tour> tours = new List<Tour>()
        {
            new Tour()
            {
                TourId = 101,
                TourName = "Kerala Backwater Tour",
                Destination = "Alleppey",
                Price = 15000,
                DurationDays = 3
            },

            new Tour()
            {
                TourId = 102,
                TourName = "Goa Beach Tour",
                Destination = "Goa",
                Price = 20000,
                DurationDays = 5
            },

            new Tour()
            {
                TourId = 103,
                TourName = "Manali Adventure Tour",
                Destination = "Manali",
                Price = 25000,
                DurationDays = 6
            }
        };

        public List<Tour> GetAllTours()
        {
            return tours;
        }
    }
}
