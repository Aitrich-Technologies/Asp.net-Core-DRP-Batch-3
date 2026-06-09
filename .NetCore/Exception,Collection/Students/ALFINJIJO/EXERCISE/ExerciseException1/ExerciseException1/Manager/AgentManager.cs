using ExerciseException1.Enum;
using ExerciseException1.Exceptions;
using ExerciseException1.Interface;
using ExerciseException1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ExerciseException1.Manager
{

    public class AgentManager 
    {
        private User loggedUser;
        private IUserRepository userRepo;

        public AgentManager(User user, IUserRepository repo)
        {
            loggedUser = user;
            userRepo = repo;
        }

        public void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Register Consultant");
                Console.WriteLine("2. View Consultants");
                Console.WriteLine("3. My Profile");
                Console.WriteLine("4. Logout");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: RegisterConsultant(); break;
                    case 2: ViewConsultants(); break;
                    case 3: ShowProfile(); break;
                    case 4: return;
                }
            }
        }

        public void RegisterConsultant()
        {
            try
            {
                Console.Write("First Name: ");
                string fname = Console.ReadLine();

                Console.Write("Last Name: ");
                string lname = Console.ReadLine();

                string email = GetValidEmail();

                long phone = GetValidPhone();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                User consultant = new User(
                    fname,
                    lname,
                    email,
                    phone,
                    password,
                    Roles.Consultant
                );

                userRepo.AddUser(consultant);

                Console.WriteLine("Consultant Registered Successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ViewConsultants()
        {
            var list = userRepo.GetConsultants();

            List.ShowConsultants(list);
        }

        public void ShowProfile()
        {
            List.ShowProfile(loggedUser);
        }

        private string GetValidEmail()
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Regex regex =
                new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!regex.IsMatch(email))
                throw new InvalidFormatException("Invalid Email");

            return email;
        }

        private long GetValidPhone()
        {
            Console.Write("Phone: ");
            string input = Console.ReadLine();

            Regex regex =
                new Regex(@"^[6-9]\d{9}$");

            if (!regex.IsMatch(input))
                throw new InvalidFormatException("Invalid Phone");

            return long.Parse(input);
        }
    }



}
