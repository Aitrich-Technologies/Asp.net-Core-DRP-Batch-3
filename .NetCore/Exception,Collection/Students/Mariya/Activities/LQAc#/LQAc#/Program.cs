using System.Collections.Generic;
    namespace LQAc;

internal class Student

{
    //public int Id { get; set; }
    //public string Name { get; set; }
    //public int Grade { get; set; }
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }


    class Enrollment
    {
        public int StudentId { get; set; }
        public string CourseName { get; set; }
    }




    static void Main(string[] args)
    {

        //List<Student> students = new List<Student>
        //{
        //    new Student { Id = 1, Name = "Alice", Grade = 85 },
        //    new Student { Id = 2, Name = "Bob", Grade = 45 },
        //    new Student { Id = 3, Name = "Charlie", Grade = 72 },
        //    new Student { Id = 4, Name = "David", Grade = 60 },
        //    new Student { Id = 5, Name = "Emma", Grade = 55 }
        //};


        //var passedStudents = students
        //    .Where(s => s.Grade >= 60)
        //    .OrderBy(s => s.Name);

        //Console.WriteLine("Students who passed:");

        //foreach (var student in passedStudents)
        //{
        //    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Grade: {student.Grade}");
        //}


        //var groupedStudents = students
        //    .GroupBy(s => s.Grade >= 60 ? "Passed" : "Failed");

        //Console.WriteLine("\nGrouped Students:");

        //foreach (var group in groupedStudents)
        //{
        //    Console.WriteLine($"\n{group.Key}:");

        //    foreach (var student in group)
        //    {
        //        Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}");
        //    }




        var students = new List<Student>
        {
            new Student { StudentId = 1, Name = "Alice", Age = 20 },
            new Student { StudentId = 2, Name = "Bob", Age = 22 },
            new Student { StudentId = 3, Name = "Charlie", Age = 23 }
        };

        var enrollments = new List<Enrollment>
        {
            new Enrollment { StudentId = 1, CourseName = "Mathematics" },
            new Enrollment { StudentId = 1, CourseName = "Physics" },
            new Enrollment { StudentId = 2, CourseName = "Chemistry" }
        };

        // Left Join using LINQ
        var result = from s in students
                     join e in enrollments
                     on s.StudentId equals e.StudentId into studentCourses
                     from sc in studentCourses.DefaultIfEmpty()
                     select new
                     {
                         StudentName = s.Name,
                         Course = sc != null ? sc.CourseName : "None"
                     };

        Console.WriteLine("Student Enrollments:");

        foreach (var item in result)
        {
            Console.WriteLine($"Student: {item.StudentName}, Course: {item.Course}");
        }





    
    }
}
