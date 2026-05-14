using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise2.Interface;
using Excercise2.Models;

namespace Excercise2.Repository
{
    public class DestinationRepository:IDestinationRepository
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

