using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseOop1.Model
{
    public class Consultant
    {
        public int ConsultantId { get; set; }
        //public string ConsultantName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int[] AssignedCustomers { get; set; } = new int[0];


        public void Display()
        {
            Console.WriteLine($"ID: {ConsultantId} | Consultant Name: {Username}");
        }

    }
}
