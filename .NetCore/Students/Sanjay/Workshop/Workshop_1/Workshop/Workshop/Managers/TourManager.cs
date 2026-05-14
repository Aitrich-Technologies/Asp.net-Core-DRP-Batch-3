using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Interface;
using Workshop.Models;

namespace Workshop.Managers
{
    internal class TourManager
    {
        private ITourRepository repo;

        public TourManager(ITourRepository repo)
        {
            this.repo = repo;
        }

        public void AddTour(string dest, double price, int seats)
        {
            repo.Add(new Tour
            {
                TourId = new Random().Next(1000),
                Destination = dest,
                Price = price,
                AvailableSeats = seats
            });
        }

        public Tour[] ViewTours() => repo.GetAll();

        public Tour GetTourById(int id) => repo.GetById(id);

        public void ReduceSeats(int id, int seats)
        {
            var t = repo.GetById(id);

            if (t == null) throw new Exception("Invalid Tour");
            if (t.AvailableSeats < seats) throw new Exception("Not enough seats");

            t.AvailableSeats -= seats;
        }
    }
}
