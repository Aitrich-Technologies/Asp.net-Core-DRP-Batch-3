using System;
using System.Collections.Generic;
using System.Text;

namespace Override_
{
    internal class SMS:Notification
    {
        public override void SendNotification()
        {
            Console.WriteLine("Sending SMS notification.");
        }
    }
}
