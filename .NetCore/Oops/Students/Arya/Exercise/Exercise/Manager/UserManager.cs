using Exercise.Enum;
using Exercise.Interface;
using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Manager
{
    
        public class UserManager
        {
            private IUserRepositary _userRepository;
            private int userCounter = 2; // 1 is reserved for admin
        private IUserRepositary userRepo;

        public UserManager(IUserRepositary userRepository)
            {
                _userRepository = userRepository;
            }

       
        public void Register()
            {
                AuthUser user = new AuthUser();

                Console.Write("Enter Username: ");
                user.Username = Console.ReadLine();

                Console.Write("Enter Password: ");
                user.Password = Console.ReadLine();

                user.UserId = userCounter++;
                user.Role = UserRoles.Customer;

                _userRepository.Register(user);

                Console.WriteLine("Registration Successful!");
            }
            public AuthUser Login()
            {
                Console.Write("Enter Username: ");
                string username = Console.ReadLine();

                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                var user = _userRepository.Login(username, password);

                if (user == null)
                {
                    Console.WriteLine("Invalid Credentials!");
                }

                return user;
            }

        }
    }

