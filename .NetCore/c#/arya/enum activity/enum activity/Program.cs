using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_activity
{
    internal class Program
    {
        //enum days
        //{
        //    monday, tuesday, wednesday, thursday, friday, saturday,sunday
        //}

        //enum jobrole
        //  {
        //    Developer,
        //    Accountant,
        //    Engineer,
        //    scientist
        //}

         enum orderstatus
        {
            pending,
            processed,
            shipped,
            Delivered,
            Cancelled

        }
        static void Main(string[] args)
        {
            //days today = days.thursday;

            //Console.WriteLine(today);

            //Console.WriteLine((int)today); numeric value

            //jobrole  role = jobrole.Developer;
            //Console.WriteLine(role);

            orderstatus status = orderstatus.Cancelled;
            Console.WriteLine((int)status);
        }
}
}
