using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_index
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
