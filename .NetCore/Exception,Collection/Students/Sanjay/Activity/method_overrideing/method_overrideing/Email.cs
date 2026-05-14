using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    class Email : Notification
    {
        public override void SendNotification()
        {
            Console.WriteLine("Email notification sent.");
        }
    }
}
