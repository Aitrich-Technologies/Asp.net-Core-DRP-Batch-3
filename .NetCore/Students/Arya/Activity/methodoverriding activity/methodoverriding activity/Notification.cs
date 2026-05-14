using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding_activity
{
    internal class Notification
    {
        public virtual void SendNotification()
        {
            Console.WriteLine("sending notification");
        }
    }
}
