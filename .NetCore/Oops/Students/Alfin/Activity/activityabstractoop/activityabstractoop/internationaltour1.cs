using System;
using System.Collections.Generic;
using System.Text;

namespace activityabstractoop
{
    internal class internationaltour1:tour
    {
        public string name {  get; set; }
        public override void ShowDetails()
        {
            Console.WriteLine("internationaltour:" +name);
        }
    }
}
