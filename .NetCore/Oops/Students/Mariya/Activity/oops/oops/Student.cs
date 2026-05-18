using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    

        
    internal class Student
    {
        public int Id;
        public string Name;
        public int age;


   public Student() {
            Id = 15;
            Name = "Raihan";
            age = 18;
        }

        public void display() {
            Console.WriteLine("students details");

            Console.WriteLine(Name);
            Console.WriteLine(Id);
            Console.WriteLine(age);


        }
    }
}
