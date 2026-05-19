using Admin_Destination.Interface;
using Admin_Destination.Manager;

internal class Program
{
    private static void Main(string[] args)
    {
        {
            TourManager tourManager = new TourManager();

            BookingManager bookingManager =
                new BookingManager(tourManager);

            IMenu menu =
                new PublicManager(tourManager, bookingManager);

            menu.DisplayMenu();
        }
    }
}