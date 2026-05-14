namespace Ens_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Tour tour = new Tour();

            tour.TourName = "Beach Escape";
            tour.Destination = "Goa";
            tour.Price = 15000;

            tour.DisplayDetails();
        }
    }
}
