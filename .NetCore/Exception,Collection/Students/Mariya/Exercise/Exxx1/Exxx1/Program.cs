using Exxx1.Managers;

namespace Exxx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TourManager manager = new TourManager();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== TOUR MANAGEMENT SYSTEM =====");

                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            manager.Register();
                            break;

                        case 2:
                            manager.Login();
                            break;

                        case 3:
                            exit = true;
                            Console.WriteLine("Thank You!");
                            break;

                        default:
                            throw new InvalidOperationException(
                                "Invalid Choice."
                            );
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(
                        "Please enter numeric values only."
                    );
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error : " + ex.Message);
                }
            }
        }
    }
}
    

