using EX_.InterFace;
using EX_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EX_.Manager
{
    public class TourManager
    {
        private ITourRepository repo;
        private int idCounter = 1;

        public TourManager(ITourRepository repo)
        {
            this.repo = repo;
        }

        public void AddTour(string dest, double price, int seats)
        {
            repo.Add(new Tour
            {
                TourId = idCounter++,
                Destination = dest,
                Price = price,
                AvailableSeats = seats
            });
        }

        public Tour[] ViewTours() => repo.GetAll();

        public Tour GetTourById(int id) => repo.GetById(id);

        public bool ReduceSeats(int tourId, int seats)
        {
            var tour = repo.GetById(tourId);
            if (tour == null || tour.AvailableSeats < seats)
                return false;

            tour.AvailableSeats -= seats;
            repo.Update(tour);
            return true;
        }
    }
}
