namespace inheritnace
{
    internal class Program
    {
        static void Main(string[] args)
        //{
        //    //User user = new User();
        //    Tourist tourist = new Tourist();
        //    TourOperator tourOperator = new TourOperator();

        //    tourist.userid = 1;
        //    tourist.name = "Test";
        //    tourist.Login();
        //    tourist.bookTour();
        //    tourOperator.createTourPackage();

        //    Console.WriteLine(tourist.userid + " " + tourist.name);
        //}

        //{
        //2


        {
            int choice;

            do
            {
                Console.WriteLine("\n===== TOUR PACKAGE SYSTEM =====");
                Console.WriteLine("1. Domestic Tour");
                Console.WriteLine("2. International Tour");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        domestictour2 d = new domestictour2();
                        d.GetDetails();
                        d.DisplayPackageType();
                        d.ShowDetails();
                        break;

                    case 2:
                        internationaltour2 i = new internationaltour2();
                        i.GetDetails();
                        i.DisplayPackageType();
                        i.ShowDetails();
                        break;

                    case 3:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 3);
        }

        //3


        //int choice;

        //do
        //{
        //    Console.WriteLine("\n===== EMPLOYEE MANAGEMENT SYSTEM =====");
        //    Console.WriteLine("1. Guide");
        //    Console.WriteLine("2. Travel Agent");
        //    Console.WriteLine("3. Exit");
        //    Console.Write("Enter your choice: ");
        //    choice = Convert.ToInt32(Console.ReadLine());

        //    switch (choice)
        //    {
        //        case 1:
        //            guide3 g = new guide3();
        //            g.GetInfo();
        //            g.DisplayInfo();
        //            break;

        //        case 2:
        //            travelagent3 t = new travelagent3();
        //            t.GetInfo();
        //            t.DisplayInfo();
        //            break;

        //        case 3:
        //            Console.WriteLine("Exiting...");
        //            break;

        //        default:
        //            Console.WriteLine("Invalid choice!");
        //            break;
        //    }

        //} while (choice != 3);

        //4

        //int choice;

        //do
        //{
        //    Console.WriteLine("\n===== TRAVEL PROFILE SYSTEM =====");
        //    Console.WriteLine("1. Solo Traveller");
        //    Console.WriteLine("2. Family Traveller");
        //    Console.WriteLine("3. Exit");
        //    Console.Write("Enter your choice: ");
        //    choice = Convert.ToInt32(Console.ReadLine());

        //    switch (choice)
        //    {
        //        case 1:
        //            solotravellerprofile solo = new solotravellerprofile();
        //            solo.GetDetails();
        //            solo.DisplayProfile();
        //            break;

        //        case 2:
        //            familytravellerprofile family = new familytravellerprofile();
        //            family.GetDetails();
        //            family.DisplayProfile();
        //            break;

        //        case 3:
        //            Console.WriteLine("Exiting...");
        //            break;

        //        default:
        //            Console.WriteLine("Invalid choice!");
        //            break;
        //    }

        //} while (choice != 3);
    }
    }
  

