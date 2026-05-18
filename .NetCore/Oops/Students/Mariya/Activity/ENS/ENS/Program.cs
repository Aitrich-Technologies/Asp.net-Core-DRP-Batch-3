namespace ENS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Student student = new Student();
            //student.SetAge(23);
            //Console.WriteLine(student.GetAge());

            //TOUR t = new TOUR();
            //t.Setname("mariya", "kerala", 30000);
            //Console.WriteLine(t.Getname());    

            //Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.Add(1, 2));
            //Console.WriteLine(calculator.Add(2, 3, 4));


            try
            {
                
                Booking booking1 = new Booking("John", "Kerala Tour", 3);

                
                Console.WriteLine("Customer: " + booking1.GetCustomerName());
                Console.WriteLine("Tour: " + booking1.GetTourName());
                Console.WriteLine("Seats: " + booking1.GetSeats());

                
                booking1.SetSeats(-2);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
