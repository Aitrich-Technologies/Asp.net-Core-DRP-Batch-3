using Machinetest.Enum;
using Machinetest.Exceptions;
using Machinetest.Manager;
using System;
using System.Data;

namespace Machinetest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Roles role = Roles.User;
            

            Console.WriteLine("Welcome " + role);
            

            Librarymanager manager = new Librarymanager();
            

            manager.start();
        }
    }
}