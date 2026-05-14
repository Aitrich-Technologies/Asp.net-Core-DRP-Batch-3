using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excercise2.Enums;
using Excercise2.Exceptions;
using Excercise2.Interface;
using Excercise2.Repository;

namespace Excercise2.Manager
{
    public class PublicManager
    {
       

        private IUserRepository userRepo = new UserRepository();
        private ITourRepository tourRepo = new TourRepository();
        private IDestinationRepository destinationRepo = new DestinationRepository();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                    Login();
                else
                    return;
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

                Console.WriteLine("Login Successful!");

                if (user.Role == Roles.Agent)
                {
                    new AgentManager(user, userRepo).ShowMenu();
                }
                else
                {
                    new ConsultantManager(user, tourRepo, destinationRepo).ShowMenu();
                }
            }
            catch (InvalidCredentialsException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //public void Login()
        //{
        //    Console.Write("Email: ");
        //    string email = Console.ReadLine();

        //    Console.Write("Password: ");
        //    string password = Console.ReadLine();

        //    var user = userRepo.Login(email, password);

        //    if (user.Role == Roles.Agent)
        //    {
        //        IAgentManager manager =
        //            new AgentManager(user, userRepo);

        //        manager.ShowMenu();
        //    }
        //    else
        //    {
        //        IConsultantManager manager =
        //            new ConsultantManager(user, tourRepo, destinationRepo);

        //        manager.ShowMenu();
        //    }
        //}
    }
}