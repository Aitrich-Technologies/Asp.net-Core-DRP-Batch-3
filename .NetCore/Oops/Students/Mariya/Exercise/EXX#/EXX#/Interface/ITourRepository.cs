using EXX_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EXX_.Interface
{
    public interface ITourRepository
    {
        void AddTour(Tour tour);
        Tour[] GetAllTours();
        Tour GetTourById(int id);
    }
}
