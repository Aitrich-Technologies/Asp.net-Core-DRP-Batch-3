using Workshop.Interface;
using Workshop.Managers;
using Workshop.Participants;
using Workshop.Repositories;

namespace Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUserRepository userRepo = new UserRepository();
            ITourRepository tourRepo = new TourRepository();
            IBookingRepository bookingRepo = new BookingRepository();
            IConsultantRepository consultantRepo = new ConsultantRepository();

            UserManager userManager = new UserManager(userRepo);
            TourManager tourManager = new TourManager(tourRepo);
            ConsultantManager consultantManager = new ConsultantManager(consultantRepo);
            BookingManager bookingManager = new BookingManager(bookingRepo, tourRepo, tourManager);

            UserParticipants app = new UserParticipants(userManager, tourManager, bookingManager, consultantManager);
            app.Start();
        }
    }
}
