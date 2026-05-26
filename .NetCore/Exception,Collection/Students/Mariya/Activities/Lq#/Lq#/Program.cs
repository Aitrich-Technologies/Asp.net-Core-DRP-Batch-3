using static System.Console;
namespace Lq_
{

    //class Student
    //
    //    //public int Id { get; set; }
    //    //public string? Name { get; set; }
    //    //public int salary { get; set; }

    //public string? Name { get; set; }
    //public string? Course { get; set; }
    //public int Age { get; set; }



    internal class Program
    {



            public static void Main()
        {




            //var scores = new List<int> { 1, 5, 2, 3, 8, 7, 9 };
            //var sortedScores = scores.OrderBy(n => n);

            //foreach (var score in sortedScores)
            //{
            //    Write($"{score} ");
            //}




            //var numbers = new[] { 1, 5, 3, 4, 7 };

            //var squares = numbers.Select(n => n * n);

            //foreach (var square in squares)
            //{
            //    WriteLine($"{square} ");
            //}







            //            var numbers = new List<int[]>()
            //{
            //    new int[] { 1, 2 },
            //    new int[] { 3, 4, 5,},
            //    new int[] { 6, 7, 8}
            //};


            //            var results = numbers.SelectMany(x => x);
            //            foreach (var number in results)
            //            {
            //                WriteLine(number);
            //            }




            //int[] numbers = { 3, 1, 4, 0, 5 };

            //var sortedNumbers = numbers.OrderByDescending(number => number);

            //foreach (var number in sortedNumbers)
            //{
            //    Write($"{number} ");
            //}



            //    var employees = new List<Employee>()
            //{
            //    new Employee { Name = "John", Department = "HR", Salary = 50000 },
            //    new Employee { Name = "Jane", Department = "IT", Salary = 60000 },
            //    new Employee { Name = "Bob", Department = "HR", Salary = 45000 },
            //    new Employee { Name = "Sara", Department = "IT", Salary = 55000 },
            //    new Employee { Name = "Tom", Department = "IT", Salary = 65000 }
            //};

            //    var results = employees.OrderBy(e => e.Department).ThenBy(e => e.Salary);

            //    foreach (var e in results)
            //    {
            //        WriteLine($"{e.Department} - {e.Name} - {e.Salary:C}");
            //    }



            //    var employees = new List<Employee>()
            //{
            //    new Employee { Name = "John", Department = "HR", Salary = 50000 },
            //    new Employee { Name = "Jane", Department = "IT", Salary = 60000 },
            //    new Employee { Name = "Bob", Department = "HR", Salary = 45000 },
            //    new Employee { Name = "Sara", Department = "IT", Salary = 55000 },
            //    new Employee { Name = "Tom", Department = "IT", Salary = 65000 }
            //};

            //    var results = employees.OrderByDescending(e => e.Department)
            //                           .ThenByDescending(e => e.Salary);

            //    foreach (var e in results)
            //    {
            //        WriteLine($"{e.Department} - {e.Name} - {e.Salary:C}");
            //    }



            //int[] scores = { 2, 5, 7, 3, 8, 9 };

            //var filteredScores = scores.Where(n => n >= 5);

            //foreach (var score in filteredScores)
            //{
            //    WriteLine(score);
            //}




            //List<int> numbers = new() { 1, 3, 7, 2, 8, 6 };

            //int firstEvenNumber = numbers.First(n => n % 2 == 0);

            //WriteLine($"The first even number is: {firstEvenNumber}");




            //List<int> numbers = new() { 1, 3, 5 };

            //int firstEvenNumber = numbers.FirstOrDefault(n => n % 2 == 0);

            //WriteLine($"The first even number is: {firstEvenNumber}");



            //List<int> numbers = new() { 1, 7, 2, 8, 6, 9 };

            //int lastEvenNumber = numbers.Last(n => n % 2 == 0);

            //WriteLine($"The last even number is: {lastEvenNumber}");



            //List<int> numbers = new() { 1, 3, 5 };

            //int lastEvenNumber = numbers.LastOrDefault(n => n % 2 == 0);

            //WriteLine($"The last even number is: {lastEvenNumber}");




            //    var employees = new List<Employee>()
            //{
            //    new Employee { Id = 1, Name = "John", Salary = 50000 },
            //    new Employee { Id = 2, Name = "Jane", Salary = 60000 },
            //    new Employee { Id = 3, Name = "Bob",  Salary = 45000 },
            //    new Employee { Id = 4, Name = "Sara", Salary = 55000 },
            //    new Employee { Id = 5, Name = "Tom",  Salary = 65000 }
            //};

            //    var employee = employees.Single(e => e.Id == 1);

            //    WriteLine($"{employee.Id} - {employee.Name}");





            //    var employees = new List<Employee>()
            //{
            //    new Employee { Id = 1, Name = "John", Salary = 50000 },
            //    new Employee { Id = 2, Name = "Jane", Salary = 60000 },
            //    new Employee { Id = 3, Name = "Bob",  Salary = 45000 },
            //    new Employee { Id = 4, Name = "Sara", Salary = 55000 },
            //    new Employee { Id = 5, Name = "Tom",  Salary = 65000 }
            //};
            //    var employee = employees.SingleOrDefault(e => e.Id == 10, null);
            //    if (employee != null)
            //    {
            //        WriteLine($"{employee.Id} - {employee.Name}");
            //    }
            //    else
            //    {
            //        WriteLine("The element was not found.");
            //    }



            //int[] numbers = { 5, 7, 2, 1, 0 };

            //bool hasNumber = numbers.Any();

            //if (hasNumber)
            //{
            //    WriteLine("The numbers has element(s).");
            //}




            //int[] numbers = { 2, 4, 6, 8 };

            //bool allEvenNumbers = numbers.All(n => n % 2 == 0 ? true : false);

            //if (allEvenNumbers)
            //{
            //    WriteLine("All numbers are even.");
            //}




            //int[] numbers = { 1, 2, 3, 4, 5 };

            //bool containsThree = numbers.Contains(3);
            //bool containsTen = numbers.Contains(10);

            //WriteLine(containsThree); // true
            //WriteLine(containsTen); // false




            //    // Create a list of students
            //    var students = new List<Student>()
            //{
            //    new Student { Name = "John", Course = "C#", Age = 25 },
            //    new Student { Name = "Jane", Course = "C#", Age = 22 },
            //    new Student { Name = "Bob", Course = "Javascript", Age = 20 },
            //    new Student { Name = "Alice", Course = "Javascript", Age = 21 }
            //};

            //    // Group the students by course
            //    var groups = students.GroupBy(s => s.Course);

            //    // Show the groups
            //    foreach (var group in groups)
            //    {
            //        Console.WriteLine(group.Key + ":");
            //        foreach (var student in group)
            //        {
            //            Console.WriteLine("- " + student.Name + " (" + student.Age + ")");
            //        }
            //        Console.WriteLine();


            //    }




            //var numbers = Enumerable.Range(0, 5);
            //foreach (var number in numbers)
            //{
            //    WriteLine(number);
            //}


            //var numbers = Enumerable.Range(0, 6)
            //            .Select(x => x * 2);

            //foreach (var number in numbers)
            //{
            //    WriteLine(number);
            //}



            //var numbers = new List<int>() { 1, 2, 3 };

            //var reversedNums = Enumerable.Reverse(numbers);

            //foreach (var number in reversedNums)
            //{
            //    WriteLine(number);
            //}



            //var numbers = Enumerable.Repeat(9, 4);
            //foreach (var number in numbers)
            //{
            //    WriteLine(number);
            //}


        }
    }
}

