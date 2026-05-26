using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    class SMS : Notification
    {
        public override void SendNotification()
        {
            Console.WriteLine("SMS notification sent.");
        }
    }
}
