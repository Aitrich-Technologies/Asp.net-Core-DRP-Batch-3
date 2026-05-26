namespace GenAC;
using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Score { get; set; }

    public Student(int id, string name, int age, double score)
    {
        Id = id;
        Name = name;
        Age = age;
        Score = score;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}, Score: {Score}");
    }
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== STUDENT MANAGEMENT =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student by ID");
            Console.WriteLine("3. Remove Student");
            Console.WriteLine("4. Update Score");
            Console.WriteLine("5. Display Fail Students");
            Console.WriteLine("6. Sort Students by Score");
            Console.WriteLine("7. Rank Students");
            Console.WriteLine("8. Second Highest Score");
            Console.WriteLine("9. Group Students (Pass/Fail)");
            Console.WriteLine("10. Display All Students");
            Console.WriteLine("0. Exit");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;

                case 2:
                    SearchStudent();
                    break;

                case 3:
                    RemoveStudent();
                    break;

                case 4:
                    UpdateScore();
                    break;

                case 5:
                    DisplayFailStudents();
                    break;

                case 6:
                    SortStudents();
                    break;

                case 7:
                    RankStudents();
                    break;

                case 8:
                    SecondHighestScore();
                    break;

                case 9:
                    GroupStudents();
                    break;

                case 10:
                    DisplayAll();
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

   
    static void AddStudent()
    {
        Console.Write("Enter ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        // Prevent Duplicate IDs
        foreach (Student s in students)
        {
            if (s.Id == id)
            {
                Console.WriteLine("Duplicate ID not allowed!");
                return;
            }
        }

        // Input Validation
        if (id < 0)
        {
            Console.WriteLine("ID cannot be negative!");
            return;
        }

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 0)
        {
            Console.WriteLine("Age cannot be negative!");
            return;
        }

        Console.Write("Enter Score: ");
        double score = Convert.ToDouble(Console.ReadLine());

        if (score < 0)
        {
            Console.WriteLine("Score cannot be negative!");
            return;
        }

        students.Add(new Student(id, name, age, score));
        Console.WriteLine("Student Added Successfully!");
    }

    
    static void SearchStudent()
    {
        Console.Write("Enter ID to search: ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Student s in students)
        {
            if (s.Id == id)
            {
                s.Display();
                return;
            }
        }

        Console.WriteLine("Student not found!");
    }

    
    static void RemoveStudent()
    {
        Console.Write("Enter ID to remove: ");
        int id = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].Id == id)
            {
                students.RemoveAt(i);
                Console.WriteLine("Student removed!");
                return;
            }
        }

        Console.WriteLine("Student not found!");
    }

    
    static void UpdateScore()
    {
        Console.Write("Enter ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Student s in students)
        {
            if (s.Id == id)
            {
                Console.Write("Enter new score: ");
                double newScore = Convert.ToDouble(Console.ReadLine());

                if (newScore < 0)
                {
                    Console.WriteLine("Invalid score!");
                    return;
                }

                s.Score = newScore;
                Console.WriteLine("Score updated!");
                return;
            }
        }

        Console.WriteLine("Student not found!");
    }

    
    static void DisplayFailStudents()
    {
        Console.WriteLine("\n--- Fail Students ---");

        foreach (Student s in students)
        {
            if (s.Score < 50)
            {
                s.Display();
            }
        }
    }

    
    static void SortStudents()
    {
        for (int i = 0; i < students.Count - 1; i++)
        {
            for (int j = i + 1; j < students.Count; j++)
            {
                if (students[i].Score > students[j].Score)
                {
                    Student temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
        }

        Console.WriteLine("\nStudents Sorted by Score:");

        foreach (Student s in students)
        {
            s.Display();
        }
    }

    
    static void RankStudents()
    {
        
        for (int i = 0; i < students.Count - 1; i++)
        {
            for (int j = i + 1; j < students.Count; j++)
            {
                if (students[i].Score < students[j].Score)
                {
                    Student temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
        }

        Console.WriteLine("\n--- Student Ranking ---");

        for (int i = 0; i < students.Count; i++)
        {
            Console.Write($"Rank {i + 1}: ");
            students[i].Display();
        }
    }

   
    static void SecondHighestScore()
    {
        if (students.Count < 2)
        {
            Console.WriteLine("Not enough students!");
            return;
        }

        Student highest = students[0];
        Student second = students[0];

        foreach (Student s in students)
        {
            if (s.Score > highest.Score)
            {
                second = highest;
                highest = s;
            }
            else if (s.Score > second.Score && s.Score != highest.Score)
            {
                second = s;
            }
        }

        Console.WriteLine("\nSecond Highest Scorer:");
        second.Display();
    }

  
    static void GroupStudents()
    {
        List<Student> passed = new List<Student>();
        List<Student> failed = new List<Student>();

        foreach (Student s in students)
        {
            if (s.Score >= 50)
                passed.Add(s);
            else
                failed.Add(s);
        }

        Console.WriteLine("\n--- Passed Students ---");
        foreach (Student s in passed)
        {
            s.Display();
        }

        Console.WriteLine("\n--- Failed Students ---");
        foreach (Student s in failed)
        {
            s.Display();
        }
    }

    
    static void DisplayAll()
    {
        Console.WriteLine("\n--- All Students ---");

        foreach (Student s in students)
        {
            s.Display();
        }
    }
}