using System;
using System.Collections.Generic;
using System.Text;
using workshopOOP.Enum;
using workshopOOP.Interface;
using workshopOOP.Model;

namespace workshopOOP.Manager
{
    public class UserManager
    {
        private IUserRepository _userRepository;
        private int userCounter = 2; // 1 is reserved for admin

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void Register()
        {
            AuthUser user = new AuthUser();

            Console.Write("Enter Username: ");
            user.UserName = Console.ReadLine();

            Console.Write("Enter Password: ");
            user.Password = Console.ReadLine();

            user.UserId = userCounter++;
            user.Roles = UserRoles.Customer;

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
