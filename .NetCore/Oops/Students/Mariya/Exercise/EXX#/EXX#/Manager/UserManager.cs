using EXX_.Enum;
using EXX_.Interface;
using EXX_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EXX_.Manager
{
    public class UserManager
    {
        private IUserRepository _userRepository;
        private IConsultantRepository _consultantRepository;

        private int userCounter = 2; // 1 is reserved for admin

        public UserManager(IUserRepository userRepository, IConsultantRepository consultantRepository)
        {
            _userRepository = userRepository;
            _consultantRepository = consultantRepository;
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

            // 🔥 STEP 1: CHECK CONSULTANT FIRST
            var consultant = _consultantRepository.Login(username, password);
            if (consultant != null)
            {
                Console.WriteLine("Login Success as Consultant");

                AuthUser authUser = new AuthUser();
                authUser.Username = consultant.Username;
                authUser.Password = consultant.Password;
                authUser.Role = UserRoles.Consultant;
                authUser.UserId = -1;

                return authUser;   // 👈 IMPORTANT: return this object
            }


            // 🔥 STEP 2: THEN CHECK USER
            var user = _userRepository.Login(username, password);
            if (user != null)
            {
                Console.WriteLine($"Login Success as {user.Role}");
                return user;
            }

            Console.WriteLine("Invalid Credentials!");
            return null;
        }

    }

}

