using Exercise.Enum;
using Exercise.Exceptions;
using Exercise.Interface;
using Exercise.Models;
using Exercise.Repository;
using System;

namespace Exercise.Manager
{
    public class PublicManager : IMenu
    {
        IUserRepository userRepo = new UserRepository();

    

        ITourRepository tourRepo = new TourRepository();

        

        Lists list = new Lists();

       

        public void DisplayMenu()
        {
            int choice = 0;

            while (choice != 6)
            {
                try
                {
                    Console.WriteLine
                    ("\n===== TOUR MANAGEMENT SYSTEM =====");

                    Console.WriteLine("1. Register");
                    Console.WriteLine("2. Login");
                    Console.WriteLine("3. View Tours");
                    Console.WriteLine("4. View Profile");
                    Console.WriteLine("5. Logout");
                    Console.WriteLine("6. Exit");

                    Console.Write
                    ("Enter Choice : ");

                    choice =
                        Convert.ToInt32
                        (Console.ReadLine());

                    switch ((Menu)choice)
                    {
                        case Menu.Register:

                            User user =
                                new User();

                            Console.Write
                            ("Enter Id : ");

                            user.Id =
                                Convert.ToInt32
                                (Console.ReadLine());

                            Console.Write
                            ("Enter Name : ");

                            user.Name =
                                Console.ReadLine();

                            Console.Write
                            ("Enter Email : ");

                            user.Email =
                                Console.ReadLine();

                            Console.Write
                            ("Enter Password : ");

                            user.Password =
                                Console.ReadLine();

                            userRepo.Register(user);

                            Console.WriteLine
                            ("Registration Successful");

                            break;

                        case Menu.Login:

                            Console.Write
                            ("Enter Email : ");

                            string email =
                                Console.ReadLine();

                            Console.Write
                            ("Enter Password : ");

                            string password =
                                Console.ReadLine();

                            var loggedUser =
                                userRepo.Login
                                (
                                    email,
                                    password
                                );

                            if (loggedUser == null)
                            {
                                throw new InvalidLoginException
                                (
                                    "Invalid Email or Password"
                                );
                            }

                            Console.WriteLine
                            ("Login Successful");

                            break;

                        case Menu.ViewTours:

                            list.PrintTours
                            (
                                tourRepo.GetTours()
                            );

                            break;

                        case Menu.ViewProfile:

                            var profile =
                                userRepo.GetLoggedUser();

                            if (profile != null)
                            {
                                list.PrintProfile(profile);
                            }

                            else
                            {
                                Console.WriteLine
                                (
                                    "Please Login First"
                                );
                            }

                            break;

                        case Menu.Logout:

                            Console.WriteLine
                            ("Logout Successful");

                            break;

                        case Menu.Exit:

                            Console.WriteLine
                            ("Application Closed");

                            break;

                        default:

                            Console.WriteLine
                            ("Invalid Choice");

                            break;
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine
                    ("Please Enter Numbers Only");
                }

                catch (OverflowException)
                {
                    Console.WriteLine
                    ("Number Too Large");
                }

                catch (InvalidLoginException ex)
                {
                    Console.WriteLine
                    (ex.Message);
                }

                catch (Exception ex)
                {
                    Console.WriteLine
                    (ex.Message);
                }
            }
        }
    }
}