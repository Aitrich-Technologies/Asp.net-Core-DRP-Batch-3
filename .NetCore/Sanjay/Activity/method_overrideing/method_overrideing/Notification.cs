using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    internal class Notification
    {
        public virtual void SendNotification()
        {
            Console.WriteLine("Sending notification...");
        }
    }
}
