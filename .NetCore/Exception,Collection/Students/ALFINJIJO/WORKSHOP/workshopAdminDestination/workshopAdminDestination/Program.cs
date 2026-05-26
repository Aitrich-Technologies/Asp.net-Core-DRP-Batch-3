using workshopAdminDestination.Interface;
using workshopAdminDestination.Manager;

namespace workshopAdminDestination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new PublicManager();
            menu.DisplayMenu();
        }
    }
}
