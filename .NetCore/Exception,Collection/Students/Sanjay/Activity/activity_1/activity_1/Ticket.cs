using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_1
{
    internal class Ticket
    {
        public int ticketId;
        public string passengerName;
        public double amount;

        public Ticket(int id, string name, double amt)
        {
            ticketId = id;
            passengerName = name;
            amount = amt;
        }
        public void Display()
        {
            Console.WriteLine("Ticket ID: " + ticketId);
            Console.WriteLine("Passenger Name: " + passengerName);
            Console.WriteLine("Amount: " + amount);
        }
    }
}
