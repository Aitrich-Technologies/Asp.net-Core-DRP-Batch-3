using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Interface
{
    public interface ITourRepository
    {
        void AddTour(Tour tour);
        Tour[] GetAllTours();
        Tour GetTourById(int id);
    }
}

