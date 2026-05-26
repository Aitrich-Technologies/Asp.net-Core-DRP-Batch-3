using ExerciseException1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseException1.Interface
{
    public interface ITourRepository
    {
        void AddTour(Tour tour);
        List<Tour> GetTours();

    }
}
