using System;
using System.Collections.Generic;
using System.Text;

namespace MachineTest
{
    internal class Student
    {
        public string Name { get; set; }

        private int age;
        public int Marks1 { get; set; }
        public int Marks2 { get; set; }
        public int Marks3 { get; set; }
        public int Marks4 { get; set; }
        public int Marks5 { get; set; }
        public int Marks6 { get; set; }


        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18 && value <= 25)
                    age = value;
                else
                    Console.WriteLine("Age must be between 18 and 25");
            }
        }



        public double CalculateCGPA()
        {
            double total = Marks1 + Marks2 + Marks3 + Marks4 + Marks5 + Marks6;
            double percentage = total / 6;

            double cgpa = percentage / 10;

            return cgpa;
        }

        public string GetGrade()
        {
            double cgpa = CalculateCGPA();

            if (cgpa >= 9 && cgpa <= 10) return "A";
            else if (cgpa >= 8) return "B";
            else if (cgpa >= 7) return "C";
            else if (cgpa >= 6) return "D";
            else if (cgpa >= 5) return "E";
            else return "Failed";
        }
    }
}

