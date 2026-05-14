using Excercise1.Interface;
using Excercise1.Manager;

internal class Program
{
    private static void Main(string[] args)
    {
        IMenu menu = new PublicManager();
        menu.DisplayMenu();

        Console.ReadLine();
    }
}