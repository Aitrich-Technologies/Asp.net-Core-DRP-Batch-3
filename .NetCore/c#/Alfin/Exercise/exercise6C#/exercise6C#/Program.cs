namespace exercise6C_
{
    internal class Program
    {
        struct CompanyMember
        {
            public int UserId;
            public string Name;
            public string Designation;
            public string Email;
            public string Phone;
        }
        static void Main(string[] args)
        {
            CompanyMember[] members = new CompanyMember[10];
            int count = 0;

            while (true) 
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Hire Me Now Job Portal!");
                Console.WriteLine("1. Login");
                Console.Write("Enter choice: ");
                int loginChoice = Convert.ToInt32(Console.ReadLine());

                if (loginChoice == 1)
                {
                    Console.Write("Please enter your email: ");
                    string email = Console.ReadLine();

                    Console.Write("Please enter your password: ");
                    string password = Console.ReadLine();

                    
                    if (email == "alfin@gmail.com" && password == "Happy123")
                    {
                        Console.WriteLine("Login successful!");

                        bool isLoggedIn = true;

                        while (isLoggedIn)
                        {
                            Console.WriteLine("\n1. List all company members");
                            Console.WriteLine("2. Register (Add company members)");
                            Console.WriteLine("3. Logout");
                            Console.Write("Enter choice: ");
                            int choice = Convert.ToInt32(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("\nCompany Members:");
                                    Console.WriteLine("UserId\tName\tDesignation\tEmail\t\tPhone");

                                    if (count == 0)
                                    {
                                        Console.WriteLine("No members found.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < count; i++)
                                        {
                                            Console.WriteLine($"{members[i].UserId}\t{members[i].Name}\t{members[i].Designation}\t{members[i].Email}\t{members[i].Phone}");
                                        }
                                    }
                                    break;

                                case 2:
                                    if (count < 10)
                                    {
                                        Console.Write("Enter User ID: ");
                                        members[count].UserId = int.Parse(Console.ReadLine());

                                        Console.Write("Enter Name: ");
                                        members[count].Name = Console.ReadLine();

                                        Console.Write("Enter Designation: ");
                                        members[count].Designation = Console.ReadLine();

                                        Console.Write("Enter Email: ");
                                        members[count].Email = Console.ReadLine();

                                        Console.Write("Enter Phone: ");
                                        members[count].Phone = Console.ReadLine();

                                        count++;

                                        Console.WriteLine("Registration successful!");

                                        
                                        Console.WriteLine("\nUpdated Company Members:");
                                        Console.WriteLine("UserId\tName\tDesignation\tEmail\t\tPhone");

                                        for (int i = 0; i < count; i++)
                                        {
                                            Console.WriteLine($"{members[i].UserId}\t{members[i].Name}\t{members[i].Designation}\t{members[i].Email}\t{members[i].Phone}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Member limit reached!");
                                    }
                                    break;

                                case 3:
                                    Console.WriteLine("Logging out...");
                                    isLoggedIn = false;
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice!");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid login!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
