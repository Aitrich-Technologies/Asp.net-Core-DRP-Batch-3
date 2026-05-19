using Admin_Destination.Interface;
using Admin_Destination.Manager;

internal class Program
{
    private static void Main(string[] args)
    {
        IMenu menu = new PublicManager();
        menu.DisplayMenu();
    }
}