using ExerciseException1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseException1.Interface
{
    public interface IDestinationRepository
    {
        void AddDestination(Destination destination);
        List<Destination> GetDestinations();

       
    }
}
