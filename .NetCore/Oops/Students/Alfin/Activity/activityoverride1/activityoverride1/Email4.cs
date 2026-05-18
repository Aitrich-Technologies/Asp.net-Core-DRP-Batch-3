using System;
using System.Collections.Generic;
using System.Text;

namespace activityoverride1
{
    internal class Email4:Notification04
    {
        public override void SendNotification()
        {
            Console.WriteLine("Sending Email notification");
        }
    }
}
