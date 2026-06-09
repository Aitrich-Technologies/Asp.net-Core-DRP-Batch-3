using Exercise.Interface;
using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Repository
{
    public class TourRepository : ITourRepository
    {
        private List<Tour> tours = new List<Tour>()
      
            {
                new Tour(1,"Munnar",3,5000),
                new Tour(2,"Goa",5,10000),
                new Tour(3,"Kashmir",7,20000)
            };

        public List<Tour> GetTours()
        {
            return tours;
        }
    }
}
