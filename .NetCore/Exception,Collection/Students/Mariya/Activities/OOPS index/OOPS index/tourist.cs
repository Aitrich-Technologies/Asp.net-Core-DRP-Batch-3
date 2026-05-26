using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_index
{
    internal class tourist
    {
        public int Id;
        public string Name;
        public int Age;


        public tourist(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
         }

        public void Display()
        {
            Console.WriteLine("Tourist ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    } 
}
