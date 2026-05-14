using Excercise2.Manager;

internal class Program
{
    private static void Main(string[] args)
    {
        //PublicManager manager = new PublicManager();
        //manager.ShowMenu();

        Console.Title = "Tour Management System";

        PublicManager publicManager = new PublicManager();

        publicManager.ShowMenu();

        Console.WriteLine("Application Closed.");
    }
}
