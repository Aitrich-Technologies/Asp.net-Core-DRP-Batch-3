using System.Text.RegularExpressions;
using static System.Console;

namespace Activity
{
    //class Student
    //{
    //    public int StudentId { get;set; }
    //    public string Name { get;set; }
    //    public int Age { get;set; }
    //}

    //class Enrollment
    //{
    //    public int Id { get;set; }
    //    public string CourseName { get;set; }
    //}

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student {Id = 1, Name = "John",Grade = 55 },
                new Student {Id = 2, Name = "Jane",Grade = 60 },
                new Student {Id = 3, Name = "Bob",Grade = 50 },
                new Student {Id = 4, Name = "Alice", Grade = 60 },
                new Student {Id = 5, Name = "Arya", Grade = 70}
            };

            var student = students.Where(s => s.Grade >= 60).OrderBy(s => s.Name);

            foreach (var item in student)
            {
                Console.WriteLine((item.Name));
            }

            var groupelement = students.GroupBy(s => s.Grade >= 60);

            foreach (var item in groupelement)
            {
                if (item.Key)
                {
                    Console.WriteLine("Passed Students");
                }
                else
                {
                    Console.WriteLine("Failed Students");
                }
                foreach (var item1 in item)
                {
                    Console.WriteLine("-" + item1.Name + " ------------- " + item1.Grade);
                }
            }

        }


        //{

        //    var students = new List<Student>()
        //    {
        //        new Student {StudentId = 1, Name = "John",Age = 55 },
        //        new Student {StudentId = 2, Name = "Jane",Age = 60 },
        //        new Student {StudentId = 3, Name = "Bob",Age = 50 },
        //        new Student {StudentId = 4, Name = "Alice", Age = 60 },
        //        new Student {StudentId = 5, Name = "Arya", Age = 70}
        //    };

        //    var enrollments = new List<Enrollment>()
        //    {
        //        new Enrollment { Id = 1, CourseName = "CS" },
        //        new Enrollment { Id = 2, CourseName = "Mech" },
        //        new Enrollment { Id = 3, CourseName = "Botony" },
        //        new Enrollment { Id = 4, CourseName = "CS" },
        //        new Enrollment { Id = 5, CourseName = "CS" }
        //    };

        //    var result = enrollments.Join(
        //        students,
        //        e => e.Id,
        //        s => s.StudentId,
        //        (e, s) => new
        //        {
        //            s.Name,
        //            s.Age,
        //            e.CourseName
        //        }).OrderBy(s => s.Name);

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r.Name + " - " + r.Age + " - " + r.CourseName);
        //    }
        //}
    }
}