namespace method_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display display = new Display();
            Console.WriteLine(display.Show("Arya"));
            Console.WriteLine(display.Show("Arya", 60));
        }

        //{
        //    Class1 c = new Class1();
        //    Console.WriteLine(c.Area(4));
        //    Console.WriteLine(c.Area(4, 3));
        //}
        //{
        //    Payment payment = new Payment();

        //    Console.WriteLine(payment.Pay(1000));
        //    //Console.WriteLine(payment.Pay(1000," UPI"));
        //    payment.Pay(5000,"UPI");

        //}
        //{
        //    Booking_System booking_System = new Booking_System();
        //    Console.WriteLine(booking_System.Book(2));
        //    Console.WriteLine(booking_System.Book(2," Arya"));
        //}

        //{
        //    Search_function search = new Search_function();
        //    Console.WriteLine(search.Tour("Tour"));
        //    Console.WriteLine(search.Tour("Tour","Delhi"));
        //}

        //{
        //    Login_system login = new Login_system();
        //    Console.WriteLine(login.Login("Alfin"));
        //    Console.WriteLine(login.Login("Alfin ", " password"));
        //}

        //{
        //    Calculate_salary calculate = new Calculate_salary();
        //    Console.WriteLine(calculate.CalculateSalary(1000));
        //    Console.WriteLine(calculate.CalculateSalary(1000,500));
        //    Console.WriteLine(calculate.CalculateSalary(1000, 500 ,100));
        //}

        //{
        //    Discount discount = new Discount();
        //    Console.WriteLine(discount.ApplyDiscount(1000));
        //    Console.WriteLine(discount.ApplyDiscount(1000, 2));
        //    Console.WriteLine(discount.ApplyDiscount(1000, 2, "discount"));
        //}

    }
}
