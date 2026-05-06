using EXX_.Enum;
using EXX_.Interface;
using EXX_.Manager;
using EXX_.Models;
using EXX_.Repository;

namespace EXX_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // Create Repository Objects
            IUserRepository userRepo = new UserRepository();
            ITourRepository tourRepo = new TourRepository();
            IBookingRepository bookingRepo = new BookingRepository();
            IConsultantRepository consultantRepo = new ConsultantRepository();


            // Create Manager Objects
            UserManager userManager = new UserManager(userRepo, consultantRepo);
            TourManager tourManager = new TourManager(tourRepo);
            BookingManager bookingManager = new BookingManager(bookingRepo, tourManager);
            ConsultantManager consultantManager = new ConsultantManager(consultantRepo, userRepo);
            while (true)
            {
                Console.WriteLine("\n==== TOUR BOOKING SYSTEM ====");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Select Option: ");

                int mainChoice = Convert.ToInt32(Console.ReadLine());
                switch (mainChoice)
                {
                    case 1:
                        userManager.Register();
                        break;

                    case 2:
                        AuthUser loggedUser = userManager.Login();
                        Console.WriteLine("AFTER LOGIN ROLE: " + loggedUser?.Role);

                        if (loggedUser == null)
                            break;

                        if (loggedUser.Role == UserRoles.Agency)
                        {
                            Console.WriteLine("DEBUG ROLE: " + loggedUser.Role);
                            AdminMenu(tourManager, bookingManager, consultantManager);
                        }
                        else if (loggedUser.Role == UserRoles.Customer)
                        {
                            Console.WriteLine("DEBUG ROLE: " + loggedUser.Role);
                            CustomerMenu(tourManager, bookingManager, loggedUser.UserId);

                        }
                        else if (loggedUser.Role == UserRoles.Consultant)
                        {
                            Console.WriteLine("DEBUG ROLE: " + loggedUser.Role);
                            ConsultantMenu(tourManager, bookingManager);
                        }
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid Option!");
                        break;
                }
            }
        } // ================= ADMIN MENU =================
        static void AdminMenu(TourManager tourManager, BookingManager bookingManager, ConsultantManager consultantManager)
        {
            while (true)
            {
                Console.WriteLine("\n==== ADMIN MENU ====");
                Console.WriteLine("1. Add Tour");
                Console.WriteLine("2. View Tours");
                Console.WriteLine("3. View All Bookings");
                Console.WriteLine("4. Add Consultant");
                Console.WriteLine("5. View Consultant");
                Console.WriteLine("6. Assign Customer to Consultant");
                Console.WriteLine("7. Logout");
                Console.Write("Select Option: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        tourManager.AddTour();
                        break;

                    case 2:
                        tourManager.ViewTours();
                        break;

                    case 3:
                        bookingManager.ViewBookings();
                        break;

                    case 4:
                        consultantManager.AddConsultant();
                        break;
                    case 5:
                        consultantManager.ViewConsultant();
                        break;
                    case 6:
                        consultantManager.AssignCustomer();
                        break;

                    case 7:
                        return;

                    default:
                        Console.WriteLine("Invalid Option!");
                        break;
                }
            }
        }
        // ================= CONSULTANT MENU =================
        static void ConsultantMenu(TourManager tourManager, BookingManager bookingManager)
        {
            while (true)
            {
                Console.WriteLine("\n==== CONSULTANT MENU ====");
                Console.WriteLine("1. View Tours");
                Console.WriteLine("2. View All Bookings");
                Console.WriteLine("3. Logout");
                Console.Write("Select Option: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        tourManager.ViewTours();
                        break;

                    case 2:
                        bookingManager.ViewBookings();
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid Option!");
                        break;
                }
            }
        }
        // ================= CUSTOMER MENU =================
        static void CustomerMenu(TourManager tourManager, BookingManager bookingManager, int userId)
        {
            while (true)
            {
                Console.WriteLine("\n==== CUSTOMER MENU ====");
                Console.WriteLine("1. View Tours");
                Console.WriteLine("2. Book Tour");
                Console.WriteLine("3. Logout");
                Console.Write("Select Option: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        tourManager.ViewTours();
                        break;

                    case 2:
                        bookingManager.BookTour(userId);
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid Option!");
                        break;
                }
            }
        }
    }
}
