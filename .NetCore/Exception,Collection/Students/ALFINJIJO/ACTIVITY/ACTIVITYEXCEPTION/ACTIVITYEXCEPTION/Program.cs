using System.Text.RegularExpressions;

namespace ACTIVITYEXCEPTION
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    internal class Program
    {
       static List<User> users = new List<User>();
        static void Main(string[] args)
        {
            char choice;

            do
            {
                User user = new User();

                user.Id = GetValidId();
                user.Name = GetValidName();
                user.Email = GetValidEmail();
                user.Phone = GetValidPhone();

                users.Add(user);

                Console.WriteLine("\nUser Added Successfully!\n");

                DisplayUsers();

                Console.Write("Add another user? (y/n): ");
                choice = Convert.ToChar(Console.ReadLine());

            } while (choice == 'y' || choice == 'Y');
        }

        static int GetValidId()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    return id;
                }
                catch
                {
                    Console.WriteLine("Invalid ID. Enter only integer value.");
                }
            }
        }

        static string GetValidName()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    if (Regex.IsMatch(name, @"\d"))
                    {
                        throw new Exception("Name cannot contain numbers.");
                    }

                    return name;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static string GetValidEmail()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Email: ");
                    string email = Console.ReadLine();

                    string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                    if (!Regex.IsMatch(email, pattern))
                    {
                        throw new Exception("Invalid Email Format.");
                    }

                    return email;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static string GetValidPhone()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Phone Number: ");
                    string phone = Console.ReadLine();

                    if (!Regex.IsMatch(phone, @"^\d{10}$"))
                    {
                        throw new Exception("Phone number must contain exactly 10 digits.");
                    }

                    return phone;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void DisplayUsers()
        {
            Console.WriteLine("----- User List -----");

            foreach (User u in users)
            {
                Console.WriteLine("ID    : " + u.Id);
                Console.WriteLine("Name  : " + u.Name);
                Console.WriteLine("Email : " + u.Email);
                Console.WriteLine("Phone : " + u.Phone);
                Console.WriteLine("----------------------");
            }
        }
    }
}
            