using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace EH2
{
   class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    internal class Program
    {
        static List<User> users = new List<User>();
        static void Main(string[] args)
        {
            
            Console.WriteLine("=== User Registration System ===");

            while (true)
            {
                try
                {
                    User user = new User();

                    
                    user.ID = GetValidID();

                  
                    user.Name = GetValidName();

                 
                    user.Email = GetValidEmail();

                    
                    user.Phone = GetValidPhone();

                   
                    users.Add(user);

                    Console.WriteLine("\nUser added successfully!");

                  
                    DisplayUsers();

                    
                    Console.Write("\nDo you want to add another user? (yes/no): ");
                    string choice = Console.ReadLine().ToLower();

                    if (choice != "yes")
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            Console.WriteLine("\nApplication Ended.");
        }

     
        static int GetValidID()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter ID: ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        throw new Exception("ID cannot be null or empty.");
                    }

                    if (!int.TryParse(input, out int id))
                    {
                        throw new Exception("ID must be an integer.");
                    }

                    return id;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid ID: " + ex.Message);
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

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        throw new Exception("Name cannot be empty.");
                    }

                    if (Regex.IsMatch(name, @"\d"))
                    {
                        throw new Exception("Name cannot contain numbers.");
                    }

                    return name;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Name: " + ex.Message);
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

                    if (string.IsNullOrWhiteSpace(email))
                    {
                        throw new Exception("Email cannot be empty.");
                    }

                    string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                    if (!Regex.IsMatch(email, pattern))
                    {
                        throw new Exception("Invalid email format.");
                    }

                    return email;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Email: " + ex.Message);
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

                    if (string.IsNullOrWhiteSpace(phone))
                    {
                        throw new Exception("Phone number cannot be empty.");
                    }

                    if (!Regex.IsMatch(phone, @"^\d{10}$"))
                    {
                        throw new Exception("Phone number must be exactly 10 digits.");
                    }

                    return phone;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Phone Number: " + ex.Message);
                }
            }
        }

      
        static void DisplayUsers()
        {
            Console.WriteLine("\n=== User List ===");

            foreach (User user in users)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("ID    : " + user.ID);
                Console.WriteLine("Name  : " + user.Name);
                Console.WriteLine("Email : " + user.Email);
                Console.WriteLine("Phone : " + user.Phone);
            }

        }
    }
}
