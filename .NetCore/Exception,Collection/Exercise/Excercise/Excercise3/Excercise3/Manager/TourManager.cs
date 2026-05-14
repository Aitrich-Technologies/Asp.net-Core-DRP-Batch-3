using Excercise3.Interface;
using Excercise3.Models;

namespace Excercise3.Manager
{
  public class TourManager : ITourProvider
    {
        private List<Tour> tours = new List<Tour>();
       public void AddTour(Tour tour)
       {
           tour.Id=tours.Count;
           tours.Add(tour);
        }
        public List<Tour> GetAllTours()
        {
         return tours;
        }
     }

 }   
    
