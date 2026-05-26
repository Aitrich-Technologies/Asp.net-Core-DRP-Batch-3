using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LINQActivity
{
    internal class Program
    {

        class student
        {
            public int id;
            public string name;

            public int grade;
            public int age;

        }

        class Enrollment
        {
            public int StudentId { get; set; }
            public string CourseName { get; set; }
        }
        static void Main(string[] args)
        {
            //List<student> students = new List<student>()
            //{
            //new student { id = 1, name = "Arya", grade = 100 },
            //new student { id = 2, name = "Anjitha", grade = 82 },
            //new student { id = 3, name = "Archa", grade = 95 },
            //new student { id = 4, name = "Sanjay", grade = 80 },
            //new student { id = 5, name = "Alfin", grade = 50  },
            //};

            //var results = students
            //    .Where(s => s.grade >= 60)
            //    .OrderBy(s => s.name);
            //Console.WriteLine("students with grade>= 60");
            //Console.WriteLine();

            //foreach (var s in results)
            //{
            //    Console.WriteLine("Id: " + s.id +
            //                      ", Name: " + s.name +
            //                      ", Grade: " + s.grade);
            //}

            //var groupedstudents = students.GroupBy(s => s.grade >= 60);
            //Console.WriteLine("grouped students");
            //Console.WriteLine();


            //foreach (var group in groupedstudents)
            //{
            //    if (group.Key)
            //    {
            //        Console.WriteLine("Passed Students:");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Failed Students:");
            //    }

            //    foreach (var s in group)
            //    {
            //        Console.WriteLine(s.name + " - " + s.grade);
            //    }
            //    Console.WriteLine();
            //}

            var students = new List<student>
            {
                new student { id = 1, name = "Alice", age = 20 },
                new student { id = 2, name = "Bob", age = 22 },
                new student { id = 3, name = "Charlie", age = 23 }
            };

            var enrollment = new List<Enrollment>
            {
                new Enrollment {StudentId = 1, CourseName ="Mathematics"},
                new Enrollment {StudentId = 2, CourseName ="Physics"},
                new Enrollment {StudentId = 3, CourseName ="Chemistry"},


            };
            var result = from s in students
                         join e in enrollment
                         on s.id equals e.StudentId
                         into temp

                         from t in temp.DefaultIfEmpty()

                         select new
                         {
                             Name = s.name,
                             Course = t == null ? "None" : t.CourseName
                         };

            foreach (var item in result)
            {
                WriteLine(item.Name + " - " + item.Course);
            }


        }
    }
}
