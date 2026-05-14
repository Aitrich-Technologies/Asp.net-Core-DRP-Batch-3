using Exercise.Models;
using Exercise.Interface;
using System;

namespace Exercise.Manager
{
    public class ConsultantManager
    {
        private IConsultantRepositary consultantRepository;
        private int id = 1;

        public ConsultantManager(IConsultantRepositary consultantRepository)
        {
            this.consultantRepository = consultantRepository;
        }

        public void ManageConsultant()
        {
            while (true)
            {
                Console.WriteLine("\n==== CONSULTANT MENU ====");
                Console.WriteLine("1. Add Consultant");
                Console.WriteLine("2. View Consultants");
                Console.WriteLine("3. Search Consultant By Id");
                Console.WriteLine("4. Exit");
                Console.Write("Select Option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Consultant Name: ");
                        string name = Console.ReadLine();
                        AddConsultant(name);
                        Console.WriteLine("Consultant Added Successfully");
                        break;

                    case 2:
                        ViewConsultants();
                        break;

                    case 3:
                        Console.Write("Enter Consultant Id: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        SearchConsultant(searchId);
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        public void AddConsultant(string name)
        {
            Consultant c = new Consultant()
            {
                consultantid = id++,
                Name = name
            };

            consultantRepository.add(c);
        }

        public void ViewConsultants()
        {
            Consultant[] consultants = consultantRepository.GetAll();

            Console.WriteLine("\nConsultants List:");

            foreach (var c in consultants)
            {
                if (c != null)
                {
                    Console.WriteLine($"{c.consultantid} - {c.Name}");
                }
            }
        }

        public void SearchConsultant(int id)
        {
            Consultant[] consultants = consultantRepository.GetById(id);

            foreach (var c in consultants)
            {
                if (c != null)
                {
                    Console.WriteLine($"ID: {c.consultantid}");
                    Console.WriteLine($"Name: {c.Name}");
                    return;
                }
            }

            Console.WriteLine("Consultant Not Found");
        }
    }
}