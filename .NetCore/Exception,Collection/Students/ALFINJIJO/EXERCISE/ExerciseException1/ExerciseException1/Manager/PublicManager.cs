using ExerciseException1.Enum;
using ExerciseException1.Exceptions;
using ExerciseException1.Interface;
using ExerciseException1.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseException1.Manager
{
    public class PublicManager
    {


        private IUserRepository userRepo = new UserRepository();
        private ITourRepository tourRepo = new TourRepository();
        private IDestinationRepository destinationRepo = new DestinationRepository();

        public void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Exit");

                int choice = int.Parse(Console.ReadLine());

             

                switch (choice)
                {
                    case 1: Login();
                        break;
                    case 2:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
        public void Login()
        {
            try
            {
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                var user = userRepo.Login(email, password);

                Console.WriteLine("Login Successful");

                if (user.Roles == Roles.Agent)
                {
                    new AgentManager(user, userRepo).DisplayMenu();
                }
                else
                {
                    new ConsultantManager(user, tourRepo, destinationRepo).DisplayMenu();
                }
            }
            catch (InvalidFormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       
    }
}
