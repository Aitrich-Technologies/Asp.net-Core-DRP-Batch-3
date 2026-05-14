using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding_activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s;

            s = new Circle();
            s.Area();

            s = new Rectangle();
            s.Area();

            EmployeeSalary E;
            
            E = new FulltimeEmployee();
            E .calculatesalary();

            E= new ParttimeEmployee();
            E.calculatesalary();

            Payment  p;
            p = new Upi();
            p.paymentprocess();

            p = new Card();
            p.paymentprocess();

            p = new Cash();
            p.paymentprocess();

            Notification n;
            n = new Email();
            n.SendNotification();

            n= new Sms();
            n.SendNotification();

            Tour t;
            t = new DomesticTour();
            t.CalculatePrice();

            t= new International_Tour();
            t.CalculatePrice();

            Booking b;
            b = new onlinebooking();
            b.confirmBooking();

            b= new Offline_booking();
            b.confirmBooking();

        }
    }
}
