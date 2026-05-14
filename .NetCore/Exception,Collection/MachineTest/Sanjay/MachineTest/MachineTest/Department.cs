using System;
using System.Collections.Generic;
using System.Text;

namespace MachineTest
{
    internal class Department : Student
    {

        public string DepartmentName { get; set; }

        public List<Student> Students = new List<Student>();
        public Student GetTopper()
        {
            Student topper = null;
            double CGPA = 0;

            foreach (var s in Students)
            {
                double cgpa = s.CalculateCGPA();

                if (cgpa > CGPA)
                {
                    CGPA = cgpa;
                    topper = s;
                }
            }
            return topper;
        }
    }
}
