using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOPACTIVITY1
{
    internal class Hotel
    {
       public string hotelName;
       public string location;
       public int roomPrice;

        public Hotel(string name, string loc, int price)
        {
            hotelName = name;
            location = loc;
            roomPrice = price;
        }

        public void Display()
        {
            Console.WriteLine(hotelName);
            Console.WriteLine(location);
            Console.WriteLine(roomPrice);
        }
    }
}
