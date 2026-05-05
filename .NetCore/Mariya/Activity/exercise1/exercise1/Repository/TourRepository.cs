using System;
using System.Collections.Generic;
using System.Text;
using exercise1.Interface;
using exercise1.Models;

namespace exercise1.Repository
{
    //internal class TourRepository
    //{
        public class TourRepository : ITourRepository
        {
            private Tour[] tours = new Tour[10];
            private int count = 0;

            public void AddTour(Tour tour)
            {
                tours[count++] = tour;
            }
            public Tour[] GetAllTours()
            {
                return tours;
            }

            public Tour GetTourById(int id)
            {
                for (int i = 0; i < count; i++)
                {
                    if (tours[i].TourId == id)
                        return tours[i];
                }
                return null;
            }
        }
    }

