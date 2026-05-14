namespace method_overrideing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Circle(5);
            s.Area();

            s = new Rectangle(4, 6);
            s.Area();
        }

        //{
        //    Employee emp;

        //    emp = new FullTimeEmployee(30000);
        //    emp.CalculateSalary();

        //    emp = new PartTimeEmployee(20, 500);
        //    emp.CalculateSalary();
        //}

        //{
        //    Booking booking;

        //    booking = new OnlineBooking();
        //    booking.ConfirmBooking();

        //    booking = new OfflineBooking();
        //    booking.ConfirmBooking();
        //}

        //{
        //    Tour t;

        //    t = new DomesticTour(2000, 3);
        //    t.CalculatePrice();

        //    t = new InternationalTour(5000, 5, 10000);
        //    t.CalculatePrice();
        //}

        //{
        //    Notification n;

        //    n = new Email();
        //    n.SendNotification();

        //    n = new SMS();
        //    n.SendNotification();
        //}

        //{
        //    Payment p;

        //    p = new UPI();
        //    p.ProcessPayment();

        //    p = new Card();
        //    p.ProcessPayment();

        //    p = new Cash();
        //    p.ProcessPayment();
        //}
    }
}
