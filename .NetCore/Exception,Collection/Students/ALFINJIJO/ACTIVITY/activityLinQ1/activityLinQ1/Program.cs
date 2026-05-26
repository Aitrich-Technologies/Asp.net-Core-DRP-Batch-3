using static System.Console;
namespace activityLinQ1
{

    //class student
    //{ 
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}

    //class Enrollment
    //{ 
    //    public int studentId { get; set; }
    //    public string CourseName { get; set; }

    //}
    class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int grade { get; set; }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new List<student>()
            {
                new student{ Id = 1, Name = "sanjay",grade =75},
                new student{ Id = 2, Name = "mariya",grade =95},
                new student{ Id = 3, Name = "arya",grade =82},
                new student{ Id = 4, Name = "alfin",grade =60},
                new student{ Id = 5, Name = "kevin",grade =55}

            };

            var result = student.Where(s => s.grade >= 60).OrderBy(s => s.Name);
            foreach (var i in result)
            {
                Console.WriteLine(i.Id + "" + i.Name + "" + i.grade);
            }
            var groupedstudent = student.GroupBy(s => s.grade >= 60);
           
            foreach (var group in groupedstudent)
            {
                if (group.Key)
                    Console.WriteLine("passed student:");
                else
                    Console.WriteLine("faild student:");
                foreach (var i in group)
                {
                    Console.WriteLine(i.Id + "" + i.Name + "" + i.grade);
                }
            }


            //    var students = new List<student>
            //{
            //    new student {Id = 1, Name = "Alice", Age = 20 },
            //    new student {Id = 2, Name = "Bob", Age = 22 },
            //    new student {Id = 3, Name = "Charlie", Age = 23 }
            //};

            //    var enrollments = new List<Enrollment>
            //{
            //    new Enrollment { studentId = 1, CourseName = "Maths" },
            //    new Enrollment { studentId = 2, CourseName = "Physics" },
            //    new Enrollment { studentId = 3, CourseName = "Chemistry" }
            //};

            //    var result = enrollments.Join(students, e => e.studentId, s => s.Id, (e, s) => new
            //    {
            //        s.Name,
            //        s.Age,
            //        e.CourseName
            //    });
            //    foreach (var i in result)
            //    { 
            //        Console.WriteLine(i.Name+""+i.Age+""+i.CourseName);
            //    }
        }

    }
}
