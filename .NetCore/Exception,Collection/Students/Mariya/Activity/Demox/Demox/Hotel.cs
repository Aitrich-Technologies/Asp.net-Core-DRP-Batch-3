using System;
using System.Collections.Generic;
using System.Text;

namespace Demox
{
    internal abstract class Hotel
    {
        public string HotelName { get; set; }
        public string Location { get; set; }

        public abstract void BookRoom();
    }
}
