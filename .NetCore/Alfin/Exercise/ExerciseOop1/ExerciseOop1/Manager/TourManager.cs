using ExerciseOop1.Interface;
using ExerciseOop1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseOop1.Manager
{
   
        public class TourManager
        {
            private ITourRepository _tourRepository;

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
                tour.Destination = Console.ReadLine();

            Console.Write("Enter Price: ");
            tour.Price = Convert.ToInt32(Console.ReadLine());

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
