////namespace Exercise
////{
////    internal class Program
////    {
////        struct employees
////        {
////            public int Id;
////            public string Name;
////            public string CompanyName;
////            public string Jobrole;

////        }

////        private static employees[] jobs =
////        [
////            new employees {Id = 1, Name ="Sanjay", CompanyName = "TCS", Jobrole = "Developer" },
////            new employees {Id = 2, Name ="Alfin", CompanyName = "Wipro", Jobrole = "Tester" },
////        ];

////        static void Main(string[] args)
////        {
////            string ch;

////            string Email = "sanjay@gmail.com";
////            string Password = "Password";

////            {
////                Console.WriteLine("Welcome to job portel");
////                Console.WriteLine("please login");
////                Console.WriteLine("Enter you email");
////                string email = Console.ReadLine();
////                Console.WriteLine("Enter your password");
////                string password = Console.ReadLine();

////                if (Email == email && Password == password)
////                {

////                        do
////                        {
////                            Console.WriteLine("login Success");
////                            Console.WriteLine("1. New Registration");
////                            Console.WriteLine("2. List all Job Seekers");
////                            Console.WriteLine("3. Search Job Seeker");
////                            Console.WriteLine("4. Logout");

////                            int choice = Convert.ToInt32(Console.ReadLine());

////                            switch (choice)
////                            {
////                                case 1:
////                                    foreach (var job in jobs)
////                                    {
////                                        Console.WriteLine("Id :" + job.Id);
////                                        Console.WriteLine("Name :" + job.Name);
////                                        Console.WriteLine("CompanyName :" + job.CompanyName);
////                                        Console.WriteLine("JobRole :" + job.Jobrole);
////                                        Console.WriteLine("====================");
////                                    }
////                                    break;
////                                case 2:
////                                    foreach (var job in jobs)
////                                    {
////                                        Console.WriteLine("Name :" + job.Name);
////                                    }

////                                    break;
////                                case 3:
////                                    Console.WriteLine("Enter your Name:");
////                                    string search = Console.ReadLine();


////                                    foreach (var job in jobs)
////                                    {
////                                        if (job.Name.Equals(search, StringComparison.OrdinalIgnoreCase))
////                                        {
////                                            Console.WriteLine("Employee Found");
////                                            Console.WriteLine("Name:" + job.Name);
////                                            Console.WriteLine("Company" + job.CompanyName);

////                                        }
////                                    }
////                                    break;
////                                case 4:
////                                    Console.WriteLine("Logged out Successfully");
////                                return;
////                                default:
////                                    Console.WriteLine("invalid choice");
////                                    break;
////                            }
////                            Console.WriteLine("Do you want to continue (Y/N)");
////                            ch = Console.ReadLine();
////                        }
////                        while (ch == "y" || ch == "Y");
////                    }

////                else
////                {
////                    Console.WriteLine("invalid user");
////                }
////            }
////        }
////    }
////}






namespace Exercise
{

    internal class Program
    {
        struct employees
        {
            public int Id;
            public string Name;
            public string CompanyName;
            public string Jobrole;

        }

        private static employees[] jobs =
        [
            new employees {Id = 1, Name ="Sanjay", CompanyName = "TCS", Jobrole = "Developer" },
            new employees {Id = 2, Name ="Alfin", CompanyName = "Wipro", Jobrole = "Tester" },
        ];

        static void Main(string[] args)
        {
            string ch;

            string Email = "sanjay@gmail.com";
            string Password = "Password";

            while (true)
            {
                Console.WriteLine("Welcome to job portel");
                Console.WriteLine("please login");
                Console.WriteLine("Enter you email");
                string email = Console.ReadLine();
                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();

                if (Email == email && Password == password)
                {
                    bool isloggedin = true;

                    while (isloggedin)
                    {

                        Console.WriteLine("login Success");
                        Console.WriteLine("====================");
                        Console.WriteLine("1. New Registrations");
                        Console.WriteLine("2. List all Job Seekers");
                        Console.WriteLine("3. Search Job Seeker");
                        Console.WriteLine("4. Logout");

                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:

                                foreach (var job in jobs)
                                {
                                    Console.WriteLine("Id :" + job.Id);
                                    Console.WriteLine("Name :" + job.Name);
                                    Console.WriteLine("CompanyName :" + job.CompanyName);
                                    Console.WriteLine("JobRole :" + job.Jobrole);
                                    Console.WriteLine("====================");
                                }
                                break;
                            case 2:
                                foreach (var job in jobs)
                                {
                                    Console.WriteLine("Name :" + job.Name);
                                }

                                break;
                            case 3:
                                Console.WriteLine("Enter your Name:");
                                string search = Console.ReadLine();

                                bool found = false;
                                foreach (var job in jobs)
                                {

                                    if (job.Name.Equals(search, StringComparison.OrdinalIgnoreCase))
                                    {
                                        Console.WriteLine("Employee Found");
                                        Console.WriteLine("Name:" + job.Name);
                                        Console.WriteLine("Company" + job.CompanyName);
                                        found = true;
                                    }
                                }
                                if (!found)
                                {
                                    Console.WriteLine("Employee not found");
                                }
                                break;
                            case 4:
                                Console.WriteLine("Logged out Successfully");
                                isloggedin = false;
                                break;

                            default:
                                Console.WriteLine("invalid choice");
                                break;
                        }
                    }
                }

                else
                {
                    Console.WriteLine("invalid user");
                }
            }
        }
    }
}





//namespace exercise1C_
//{
//    internal class Program
//    {
//        struct companymember
//        {
//            public int userid;
//            public string Name;
//            public string Designation;
//            public string Email;
//            public string Phone;
//        }
//        static void Main(string[] args)
//        {
//            companymember[] members = new companymember[10];
//            int count = 0;
//            int choice;

//            while (true)
//            {
//                Console.WriteLine("\nWelcome to the Hire Me Now Job portal!\n");

//                Console.WriteLine("1. Login");
//                Console.WriteLine("2. Register");
//                Console.WriteLine("3. Exit");
//                Console.Write("Enter choice: ");
//                int loginChoice = Convert.ToInt32(Console.ReadLine());


//                if (loginChoice == 2)
//                {
//                    if (count < 10)
//                    {
//                        Console.WriteLine("\n--- Register Company Member ---");

//                        Console.Write("Enter name: ");
//                        members[count].Name = Console.ReadLine();

//                        Console.Write("Enter email: ");
//                        members[count].Email = Console.ReadLine();

//                        Console.Write("Enter designation: ");
//                        members[count].Designation = Console.ReadLine();

//                        Console.Write("Enter phone number: ");
//                        members[count].Phone = Console.ReadLine();

//                        members[count].userid = count + 1;
//                        count++;

//                        Console.WriteLine("Registration successful!\n");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Member list is full!");
//                    }
//                }
//                else if (loginChoice == 1)
//                {
//                    Console.Write("Please enter your email: ");
//                    string email = Console.ReadLine();

//                    Console.Write("Please enter your password: ");
//                    string password = Console.ReadLine();

//                    if (email == "job@gmail.com" && password == "123")
//                    {
//                        Console.WriteLine("Login successful!\n");

//                        do
//                        {
//                            Console.WriteLine("\n1. List all company members");
//                            Console.WriteLine("2. Add company members");
//                            Console.WriteLine("3. Logout");
//                            Console.Write("Enter your choice: ");
//                            choice = Convert.ToInt32(Console.ReadLine());

//                            switch (choice)
//                            {

//                                case 1:
//                                    Console.WriteLine("\nCompany Members:\n");
//                                    Console.WriteLine("UserId\tName\tDesignation\tEmail\t\t\tPhone");

//                                    if (count == 0)
//                                    {
//                                        Console.WriteLine("No members found.");
//                                    }
//                                    else
//                                    {
//                                        for (int i = 0; i < count; i++)
//                                        {
//                                            Console.WriteLine($"{members[i].userid}\t{members[i].Name}\t{members[i].Designation}\t{members[i].Email}\t{members[i].Phone}");
//                                        }
//                                    }
//                                    break;


//                                case 2:
//                                    if (count < 10)
//                                    {
//                                        Console.Write("\nEnter company member name: ");
//                                        members[count].Name = Console.ReadLine();

//                                        Console.Write("Enter email: ");
//                                        members[count].Email = Console.ReadLine();

//                                        Console.Write("Enter designation: ");
//                                        members[count].Designation = Console.ReadLine();

//                                        Console.Write("Enter phone number: ");
//                                        members[count].Phone = Console.ReadLine();

//                                        members[count].userid = count + 1;
//                                        count++;

//                                        Console.WriteLine("Member added successfully!");
//                                    }
//                                    else
//                                    {
//                                        Console.WriteLine("Member list is full!");
//                                    }
//                                    break;


//                                case 3:
//                                    Console.WriteLine("Logged out successfully.");
//                                    break;

//                                default:
//                                    Console.WriteLine("Invalid choice!");
//                                    break;
//                            }

//                        } while (choice != 3);
//                    }
//                    else
//                    {
//                        Console.WriteLine("Invalid login credentials!");
//                    }
//                }


//                else if (loginChoice == 3)
//                {
//                    Console.WriteLine("Exiting program...");
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Invalid option!");
//                }
//            }
//        }
//    }
//}