using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding_activity
{
    internal class Sms:Notification
    {
        public override void SendNotification()
        {
            Console.WriteLine("notification sent in sms");
        }

    }
}
