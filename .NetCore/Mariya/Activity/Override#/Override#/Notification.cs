using System;
using System.Collections.Generic;
using System.Text;

namespace Override_
{
    internal class Notification
    {
        public virtual void SendNotification()
        {
            Console.WriteLine("Sending general notification...");
        }
    }
}
