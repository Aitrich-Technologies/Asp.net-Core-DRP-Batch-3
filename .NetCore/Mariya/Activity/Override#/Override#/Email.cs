using System;
using System.Collections.Generic;
using System.Text;

namespace Override_
{
    internal class Email:Notification
    {
        public override void SendNotification()
        {
            Console.WriteLine("Sending Email notification.");
        }
    }
}
