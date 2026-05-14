using ExerciseOop1.Enum;
using ExerciseOop1.Interface;
using ExerciseOop1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseOop1.Manager
{
    public class ConsultantManager
    {
        private IConsultantRepository _ConsultantRepository;
        private IUserRepository _userRepository;

        public ConsultantManager(IConsultantRepository consultantRepository, IUserRepository userRepository)
        {
            _ConsultantRepository = consultantRepository;
            _userRepository = userRepository;
        }
        public void AddConsultant()
        {
            Consultant consultant = new Consultant();

            Console.Write("Enter Consultant ID: ");
            consultant.ConsultantId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Username: ");
            consultant.Username = Console.ReadLine();

            Console.Write("Enter Password: ");
            consultant.Password = Console.ReadLine();

            //consultant.Role = UserRoles.Consultant;
            _ConsultantRepository.AddConsultant(consultant);

            Console.WriteLine("Consultant Added Successfully!");
        }

        public void ViewConsultant()
        {
            var consultants = _ConsultantRepository.GetAllConsultant();

            foreach (var consultant in consultants)
            {
                if (consultant != null)
                    consultant.Display();
            }
        }

        public void AssignCustomer()
        {
            Console.Write("Enter Consultant ID: ");
            int consultantId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer User ID: ");
            int userId = Convert.ToInt32(Console.ReadLine());

            
            var users = _userRepository.GetAll(); 

            bool isValidCustomer = false;

            foreach (var user in users)
            {
                if (user != null && user.UserId == userId && user.Role == UserRoles.Customer)
                {
                    isValidCustomer = true;
                    break;
                }
            }

            if (!isValidCustomer)
            {
                Console.WriteLine(" Invalid Customer ID!");
                return;
            }

            _ConsultantRepository.AssignCustomer(consultantId, userId);
        }


    }
}

    