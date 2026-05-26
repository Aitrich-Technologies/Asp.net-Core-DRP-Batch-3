using ExerciseException1.Manager;

namespace ExerciseException1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome To Tour Management System");

            PublicManager publicManager = new PublicManager();

            publicManager.DisplayMenu();

           
        }

    }
    
}
