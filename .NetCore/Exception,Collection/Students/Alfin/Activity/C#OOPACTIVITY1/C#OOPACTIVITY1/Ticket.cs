using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOPACTIVITY1
{
    internal class Ticket
    {
       public int ticketId;
       public string passengerName;
       public int amount;

        public Ticket(int id, string name, int amt)
        {
            ticketId = id;
            passengerName = name;
            amount = amt;
        }

        public void Display()
        {
            Console.WriteLine(ticketId);
            Console.WriteLine(passengerName);
            Console.WriteLine(amount);
        }
    }
}
