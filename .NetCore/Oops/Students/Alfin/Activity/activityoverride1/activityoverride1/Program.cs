using System.Drawing;

namespace activityoverride1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shape01 s;
            //s = new Circle1();
            //s.Area();
            //s = new Rectangle1();
            //s.Area();


            //employee02 emp;
            //emp = new FullTimeEmployee2();
            //emp.CalculateSalary();
            //emp = new PartTimeEmployee2();
            //emp.CalculateSalary();


            //payment03 p;
            //p = new UPI3();
            //p.ProcessPayment();
            //p = new Card3();
            //p.ProcessPayment();
            //p = new Cash3();
            //p.ProcessPayment();


            //Notification04 n;
            //n = new Email4();
            //n.SendNotification();
            //n = new SMS4();
            //n.SendNotification();


            //Tour05 t;
            //t = new DomesticTour5();
            //t.CalculatePrice();
            //t = new InternationalTour5();
            //t.CalculatePrice();


            Booking06 b;
            b = new OnlineBooking6();
            b.ConfirmBooking();
            b = new OfflineBooking6();
            b.ConfirmBooking();




        }
    }
}
