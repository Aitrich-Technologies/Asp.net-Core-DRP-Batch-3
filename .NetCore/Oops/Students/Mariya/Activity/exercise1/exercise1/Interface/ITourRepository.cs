using System;
using System.Collections.Generic;
using System.Text;
using exercise1.Models;

namespace exercise1.Interface
{
    //internal class ITourRepository
    
        public interface ITourRepository
        {
            void AddTour(Tour tour);
            Tour[] GetAllTours();
            Tour GetTourById(int id);
        }
    
}
