using System;
using System.Collections.Generic;
using System.Text;
using exercise1.Interface;
using exercise1.Models;


namespace exercise1.Manager
{
    //internal class TourManager
    
        public class TourManager
        {

        private ITourRepositary _tourRepository;


        public TourManager(ITourRepository tourRepository)
        {
            _tourRepository = tourRepository;
        }
        public void AddTour()
            {
                Tour tour = new Tour();

                Console.Write("Enter Tour ID: ");
                tour.TourId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Destination: ");
                tour.Destination = Convert.ToInt32(Console.ReadLine());

                //Console.Write("Enter Price: ");
                //tour.Price = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter Available Seats: ");
                tour.AvailableSeats = Convert.ToInt32(Console.ReadLine());

                _tourRepository.AddTour(tour);

                Console.WriteLine("Tour Added Successfully!");
            }
            public void ViewTours()
            {
                var tours = _tourRepository.GetAllTours();

                foreach (var tour in tours)
                {
                    if (tour != null)
                        tour.Display();
                }
            }

            public Tour GetTourById(int id)
            {
                return _tourRepository.GetTourById(id);
            }
            public bool ReduceSeats(Tour tour, int seats)
            {
                if (tour.AvailableSeats >= seats)
                {
                    tour.AvailableSeats -= seats;
                    return true;
                }
                return false;
            }
        }
    }

