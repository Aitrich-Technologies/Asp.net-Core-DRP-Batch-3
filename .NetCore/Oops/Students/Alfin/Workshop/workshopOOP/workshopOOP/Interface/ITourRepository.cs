using System;
using System.Collections.Generic;
using System.Text;
using workshopOOP.Model;

namespace workshopOOP.Interface
{
    public interface ITourRepository
    {
        void AddTour(Tour tour);
        Tour[] GetAllTours();
        Tour GetTourById(int id);
    }
}
