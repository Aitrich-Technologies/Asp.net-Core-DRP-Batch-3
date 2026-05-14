using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise3.Models;

namespace Excercise3
{
   public class DisplayDetails
    {
        public void Print(List<User> Agents)
        {
            Console.WriteLine("Registraions:\n");
            Console.WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20} ", "Id", "First Name", "Last Name", "Phone", "Email");
            if (Agents != null)
        
                foreach (User agent in Agents)
                {
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20} ", agent.Id, agent.FirstName, agent.LastName, agent.Phone, agent.Email);
                }
                Console.WriteLine("\n");
        } 
        
        public void Print(List<Tour> tours)
        {
            Console.WriteLine("Tours:\n");
            Console.WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}", "TourId", "Destination", "Days", "Price");
            
            if (tours != null)
                foreach (Tour tour in tours)
                {
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("{0,10}|{1,-20}|{2,-20}|{3,-20}", tour.Id, tour.Destination, tour.Days,tour.Price);
                }
            Console.WriteLine("\n");
        }

    }
}
