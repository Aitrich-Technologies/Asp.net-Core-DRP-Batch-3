using System;
using System.Collections.Generic;
using System.Text;

namespace activityabstractoop
{
    internal class domestictour1:tour
    {
        public int id {  get; set; }

        public override void ShowDetails()
        {
            Console.WriteLine("domestictout :" + id);
        }

    }
}
