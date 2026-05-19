namespace Demox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello, World!");
            ///

            //Tour

            //Tour domestic = new Domestictour()
            //{
            //    TourName = "Kerala Backwaters",
            //    Destination = "Alleppey"
            //};

            //Tour international = new Internationaltour()
            //{
            //    TourName = "Europe Trip",
            //    Destination = "France"
            //};

            //domestic.ShowDetails();
            //Console.WriteLine();
            //international.ShowDetails();


            //payment

            //Payment p1 = new cardpayment();
            //p1.MakePayment();

            //Payment p2 = new UPI_payment();
            //p2.MakePayment();

            //Package

            //Luxuarypackage luxury = new Luxuarypackage();
            //luxury.BasePrice = 10000;
            //luxury.ExtraCharges = 3000;

            //Budgetpackage budget = new Budgetpackage();
            //budget.BasePrice = 10000;
            //budget.Discount = 2000;

            //Console.WriteLine("Luxury Package Price: " + luxury.CalculatePrice());
            //Console.WriteLine("Budget Package Price: " + budget.CalculatePrice());


            //Transport

            //Transpot t1 = new Bus();
            //Transpot t2 = new Flight();
            //Transpot t3 = new Train();

            //t1.Travel();
            //t2.Travel();
            //t3.Travel();

            //Hotel

            //Hotel h1 = new Standardroom();
            //h1.HotelName = "Sunrise Hotel";
            //h1.Location = "Goa";

            //Hotel h2 = new Deluxroom();
            //h2.HotelName = "Grand Palace";
            //h2.Location = "Mumbai";

            //h1.BookRoom();
            //h2.BookRoom();


            //Guide
            Guide g1 = new Cityguide();
            Guide g2 = new Adventureguide();

            g1.ExplainPlace();
            g2.ExplainPlace();



        }
    }
}
