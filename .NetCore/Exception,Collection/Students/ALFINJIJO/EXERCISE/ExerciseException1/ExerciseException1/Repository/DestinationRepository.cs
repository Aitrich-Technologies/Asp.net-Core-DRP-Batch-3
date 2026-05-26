using ExerciseException1.Interface;
using ExerciseException1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseException1.Repository
{
    public class DestinationRepository : IDestinationRepository
    {
        private List<Destination> destinations = new List<Destination>();

        public void AddDestination(Destination destination)
        {
            destinations.Add(destination);
        }

        public List<Destination> GetDestinations()
        {
            return destinations;
        }
    }
}
