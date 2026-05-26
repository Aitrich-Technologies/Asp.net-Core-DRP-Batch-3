using System;
using System.Collections.Generic;
using System.Text;
using WRK_.Models;

namespace WRK_.Interface
{
    //internal class ITourRepository
    {
        public interface ITourRepository
        {
            void AddTour(Tour tour);
            Tour[] GetAllTours();
            Tour GetTourById(int id);
        }
    }

