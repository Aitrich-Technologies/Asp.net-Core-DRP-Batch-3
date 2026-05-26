namespace Abstraction_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello, World!");
            //Tour t = new Tourbooking();
            //t.Booking();

            person p;
            p = new customer { CustomerID = 1, phonenumber = 4567 };
            p.DisplayDetails();

            p = new employee { Employeeid = 3, position = "HR"};
            p.DisplayDetails();
         



        }
    }
}

           