
namespace JobPortalApp
{
    class User
    {
        public string Name;
        public string Email;
        public string Password;
    }

    class Job
    {
        public int Id;
        public string Title;
        public string Company;
        public string Location;
    }

    class Program
    {
        static List<User> users = new List<User>();
        static List<Job> jobs = new List<Job>();
        static User loggedInUser = null;

        static void Main(string[] args)
        {
            SeedJobs();

            while (true)
            {
                Console.WriteLine("\nWelcome to Job Portal");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Register();
                        break;

                    case 2:
                        Login();
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        // 🔹 Register
        static void Register()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            users.Add(new User { Name = name, Email = email, Password = password });

            Console.WriteLine("Registration successful!");
        }

        // 🔹 Login
        static void Login()
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            foreach (var user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    loggedInUser = user;
                    Console.WriteLine($"Login successful! Welcome {user.Name}");
                    UserMenu();
                    return;
                }
            }

            Console.WriteLine("Invalid email or password!");
        }

        // 🔹 After Login Menu
        static void UserMenu()
        {
            while (loggedInUser != null)
            {
                Console.WriteLine("\n1. List all jobs");
                Console.WriteLine("2. My profile");
                Console.WriteLine("3. Logout");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ShowJobs();
                        break;

                    case 2:
                        ShowProfile();
                        break;

                    case 3:
                        Logout();
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        // 🔹 Show Jobs
        static void ShowJobs()
        {
            Console.WriteLine("\nJobs Available:");
            foreach (var job in jobs)
            {
                Console.WriteLine($"{job.Id}. {job.Title} - {job.Company} ({job.Location})");
            }
        }

        // 🔹 Show Profile
        static void ShowProfile()
        {
            Console.WriteLine("\nMy Profile:");
            Console.WriteLine($"Name: {loggedInUser.Name}");
            Console.WriteLine($"Email: {loggedInUser.Email}");
        }

        // 🔹 Logout
        static void Logout()
        {
            Console.WriteLine("Logged out successfully!");
            loggedInUser = null;
        }

        // 🔹 Predefined Jobs
        static void SeedJobs()
        {
            jobs.Add(new Job { Id = 1, Title = "Software Engineer", Company = "Acme Inc.", Location = "New York" });
            jobs.Add(new Job { Id = 2, Title = "Product Manager", Company = "Globex Corp.", Location = "San Francisco" });
            jobs.Add(new Job { Id = 3, Title = "Marketing Specialist", Company = "Hooli", Location = "Seattle" });
        }
    }
}