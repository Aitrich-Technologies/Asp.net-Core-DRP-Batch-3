namespace Override_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Shape s1 = new Circle(5);
            Shape s2 = new Rectangle(4, 6);

            Console.WriteLine($"Circle Area: {s1.Area()}");
            Console.WriteLine($"Rectangle Area: {s2.Area()}");



            Employee emp1 = new FullTimeEmployee(30000);
            Employee emp2 = new PartTimeEmployee(40, 200);

            Console.WriteLine($"Full-Time Salary: {emp1.CalculateSalary()}");
            Console.WriteLine($"Part-Time Salary: {emp2.CalculateSalary()}");




            Payment p1 = new UPI();
            Payment p2 = new Card();
            Payment p3 = new Cash();

            p1.ProcessPayment();
            p2.ProcessPayment();
            p3.ProcessPayment();





            Notification n1 = new Email();
            Notification n2 = new SMS();

            n1.SendNotification();
            n2.SendNotification();





            Tour t1 = new Domestic(3, 2000);
            Tour t2 = new International(5, 5000, 10000);

            Console.WriteLine($"Domestic Tour Price: {t1.CalculatePrice()}");
            Console.WriteLine($"International Tour Price: {t2.CalculatePrice()}");



            Booking b1 = new OnlineBooking();
            Booking b2 = new OfflineBooking();

            b1.ConfirmBooking();
            b2.ConfirmBooking();
        }
    }
}
