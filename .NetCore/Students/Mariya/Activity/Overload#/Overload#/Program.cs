namespace Overload_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            DisplayInfo obj = new DisplayInfo();

            obj.Display("John");          // Calls first method
            obj.Display("Alice", 25);     // Calls overloaded method



            AreaCalculator calc = new AreaCalculator();

            int squareArea = calc.Area(5);
            int rectangleArea = calc.Area(4, 6);

            Console.WriteLine($"Area of Square: {squareArea}");
            Console.WriteLine($"Area of Rectangle: {rectangleArea}");




            Payment payment = new Payment();

            payment.Pay(1000);                 // Calls first method
            payment.Pay(1000, "UPI");          // Calls overloaded method




            Booking booking = new Booking();

            booking.Book(3);                 // Calls first method
            booking.Book(2, "Rahul");        // Calls overloaded method




            SearchSystem search = new SearchSystem();

            search.Search("Hotels");                  // Calls first method
            search.Search("Restaurants", "Kochi");    // Calls overloaded method



            DiscountSystem ds = new DiscountSystem();

            ds.ApplyDiscount(1000);                      // No discount
            ds.ApplyDiscount(1000, 10);                  // With percentage
            ds.ApplyDiscount(1000, 15, "SAVE15");        // With coupon




            EmployeeSalary emp = new EmployeeSalary();

            emp.CalculateSalary(20000);                // Basic only
            emp.CalculateSalary(20000, 5000);          // With bonus
            emp.CalculateSalary(20000, 5000, 2000);    // With bonus and tax



            LoginSystem login = new LoginSystem();

            login.Login("john");                 // Guest login
            login.Login("john", "1234");         // Full login
        }
    }
}
