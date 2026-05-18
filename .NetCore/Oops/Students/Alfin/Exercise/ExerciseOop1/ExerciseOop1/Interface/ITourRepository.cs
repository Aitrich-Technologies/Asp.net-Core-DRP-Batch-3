using ExerciseOop1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseOop1.Interface
{
    public interface ITourRepository
    {
        void AddTour(Tour tour);
        Tour[] GetAllTours();
        Tour GetTourById(int id);
    }

}
