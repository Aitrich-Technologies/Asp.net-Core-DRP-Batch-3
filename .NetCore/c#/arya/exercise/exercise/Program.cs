using System;

namespace CompanyApp
{
    struct Company
    {
        public string CompanyName;
        public string Email;
        public string Website;
        public string Phone;
        public string Location;
        public string Password;
    }

    struct Interview
    {
        public string Title;
        public string Date;
        public string Time;
        public string Location;
        public string CompanyEmail;
    }

    class Program
    {
        static Company[] companies = new Company[10];
        static Interview[] interviews = new Interview[20];

            static int companyCount = 0;
            static int interviewCount = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== MAIN MENU =====");
                Console.WriteLine("1. Register Company");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        RegisterCompany();
                        break;

                    case 2:
                        Login();
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        static void RegisterCompany()
        {
            if (companyCount >= 10)
            {
                Console.WriteLine("Company limit reached!");
                return;
            }

            Company c = new Company();

            Console.Write("Company Name: ");
            c.CompanyName = Console.ReadLine();

            Console.Write("Email: ");
            c.Email = Console.ReadLine();

            Console.Write("Website: ");
            c.Website = Console.ReadLine();

            Console.Write("Phone: ");
            c.Phone = Console.ReadLine();

            Console.Write("Location: ");
            c.Location = Console.ReadLine();

            Console.Write("Password: ");
            c.Password = Console.ReadLine();

            companies[companyCount] = c;
            companyCount++;

            Console.WriteLine("Company Registered!");
        }

        static void Login()
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            for (int i = 0; i < companyCount; i++)
            {
                if (companies[i].Email == email && companies[i].Password == password)
                {
                    Console.WriteLine("✅ Login Successful!");
                    CompanyMenu(companies[i]);
                    return;
                }
            }

            Console.WriteLine("❌ Invalid Login");
        }

        static void CompanyMenu(Company company)
        {
            while (true)
            {
                Console.WriteLine("\n1. Schedule Interview");
                Console.WriteLine("2. View Interviews");
                Console.WriteLine("3. Logout");

                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ScheduleInterview(company);
                        break;

                    case 2:
                        ViewInterviews(company);
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        static void ScheduleInterview(Company company)
        {
            if (interviewCount >= 20)
            {
                Console.WriteLine("Interview limit reached!");
                return;
            }

            Interview i = new Interview();

            Console.Write("Title: ");
            i.Title = Console.ReadLine();

            Console.Write("Date: ");
            i.Date = Console.ReadLine();

            Console.Write("Time: ");
            i.Time = Console.ReadLine();

            Console.Write("Location: ");
            i.Location = Console.ReadLine();

            i.CompanyEmail = company.Email;

            interviews[interviewCount] = i;
            interviewCount++;

            Console.WriteLine("✅ Interview Scheduled!");
        }

        static void ViewInterviews(Company company)
        {
            Console.WriteLine("\n--- Interviews ---");

            for (int i = 0; i < interviewCount; i++)
            {
                if (interviews[i].CompanyEmail == company.Email)
                {
                    Console.WriteLine("Title: " + interviews[i].Title);
                    Console.WriteLine("Date: " + interviews[i].Date);
                    Console.WriteLine("Time: " + interviews[i].Time);
                    Console.WriteLine("Location: " + interviews[i].Location);
                    Console.WriteLine("------------------");
                }
            }
        }
    }
}