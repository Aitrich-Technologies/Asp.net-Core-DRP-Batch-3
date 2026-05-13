using EX_.Enum;
using EX_.Manager;
using EX_.Participants;
using EX_.Repository;
using System.Reflection;

namespace EX_
{
    class Program
    {
        static void Main()
        {
            var userRepo = new UserRepository();
            var tourRepo = new TourRepository();
            var bookingRepo = new BookingRepository();
            var consultantRepo = new ConsultantRepository();

            var userManager = new UserManager(userRepo);
            var consultantManager = new ConsultantManager(consultantRepo);
            var tourManager = new TourManager(tourRepo);
            var bookingManager = new BookingManager(bookingRepo, tourManager);

            // Seed Admin + Consultant login users
            userManager.Register("admin", "123", UserRoles.Admin);
            userManager.Register("consultant", "123", UserRoles.Consultant);

            var app = new UserParticipants(userManager, consultantManager, tourManager, bookingManager);
            app.Start();
        }
    }
}