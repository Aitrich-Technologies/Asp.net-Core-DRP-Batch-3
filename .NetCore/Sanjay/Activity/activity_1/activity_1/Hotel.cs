using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_1
{
    internal class Hotel
    {
        public string HotelName;
        public string location;
        public double roomPrice;

        public Hotel(string name, string loc, double price)
        {
            HotelName = name;
            location = loc;
            roomPrice = price;
        }
        public void Display()
        {
            Console.WriteLine("Hotel Name: " + HotelName);
            Console.WriteLine("Location: " + location);
            Console.WriteLine("Room Price: " + roomPrice);
        }

    }
}
