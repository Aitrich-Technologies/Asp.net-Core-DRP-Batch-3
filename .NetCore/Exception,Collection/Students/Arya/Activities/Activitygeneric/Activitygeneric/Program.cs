using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activitygeneric
{
    internal class Student
    {
        public int Id;
        public string Name;
        public int Age;
        public int Score;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                Console.WriteLine("----- STUDENT MANAGEMENT -----");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Search Student by ID");
                Console.WriteLine("3. Remove Student");
                Console.WriteLine("4. Update Score");
                Console.WriteLine("5. Display Fail Students");
                Console.WriteLine("6. Sort Students");
                Console.WriteLine("7. Rank Students");
                Console.WriteLine("8. Second Highest Score");
                Console.WriteLine("9. Group Students (Pass/Fail)");
                Console.WriteLine("10. Display All Students");
                Console.WriteLine("11. Exit");

                Console.Write("Enter Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent(students);
                        break;

                    case 2:
                        SearchStudent(students);
                        break;

                    case 3:
                        RemoveStudent(students);
                        break;

                    case 4:
                        UpdateScore(students);
                        break;

                    case 5:
                        DisplayFailStudents(students);
                        break;

                    case 6:
                        SortStudents(students);
                        break;

                    case 7:
                        RankStudents(students);
                        break;

                    case 8:
                        SecondHighest(students);
                        break;

                    case 9:
                        GroupStudents(students);
                        break;

                    case 10:
                        DisplayAll(students);
                        break;

                    case 11:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        // Add Student
        static void AddStudent(List<Student> students)
        {
            Student s = new Student();

            Console.Write("Enter ID: ");
            s.Id = Convert.ToInt32(Console.ReadLine());

            // Prevent Duplicate IDs
            foreach (Student st in students)
            {
                if (st.Id == s.Id)
                {
                    Console.WriteLine("ID already exists!");
                    return;
                }
            }

            // Input Validation
            if (s.Id < 0)
            {
                Console.WriteLine("ID cannot be negative");
                return;
            }

            Console.Write("Enter Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            s.Age = Convert.ToInt32(Console.ReadLine());

            if (s.Age < 0)
            {
                Console.WriteLine("Age cannot be negative");
                return;
            }

            Console.Write("Enter Score: ");
            s.Score = Convert.ToInt32(Console.ReadLine());

            if (s.Score < 0)
            {
                Console.WriteLine("Score cannot be negative");
                return;
            }

            students.Add(s);

            Console.WriteLine("Student Added Successfully");
        }

        // Search Student by ID
        static void SearchStudent(List<Student> students)
        {
            Console.Write("Enter ID to Search: ");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (Student s in students)
            {
                if (s.Id == id)
                {
                    Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}, Score: {s.Score}");
                    return;
                }
            }

            Console.WriteLine("Student Not Found");
        }

        // Remove Student
        static void RemoveStudent(List<Student> students)
        {
            Console.Write("Enter ID to Remove: ");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == id)
                {
                    students.RemoveAt(i);
                    Console.WriteLine("Student Removed");
                    return;
                }
            }

            Console.WriteLine("Student Not Found");
        }

        // Update Score
        static void UpdateScore(List<Student> students)
        {
            Console.Write("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (Student s in students)
            {
                if (s.Id == id)
                {
                    Console.Write("Enter New Score: ");
                    int newScore = Convert.ToInt32(Console.ReadLine());

                    if (newScore < 0)
                    {
                        Console.WriteLine("Invalid Score");
                        return;
                    }

                    s.Score = newScore;

                    Console.WriteLine("Score Updated");
                    return;
                }
            }

            Console.WriteLine("Student Not Found");
        }

        // Display Fail Students
        static void DisplayFailStudents(List<Student> students)
        {
            Console.WriteLine("\nFail Students:");

            foreach (Student s in students)
            {
                if (s.Score < 50)
                {
                    Console.WriteLine($"{s.Name} - {s.Score}");
                }
            }
        }

        // Sort Students Without LINQ
        static void SortStudents(List<Student> students)
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
                Console.WriteLine($"{s.Name} - {s.Score}");
            }
        }

        // Rank Students
        static void RankStudents(List<Student> students)
        {
            // Descending Sort
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

            Console.WriteLine("\nStudent Ranks:");

            int rank = 1;

            foreach (Student s in students)
            {
                Console.WriteLine($"Rank {rank}: {s.Name} - {s.Score}");
                rank++;
            }
        }

        // Second Highest Score
        static void SecondHighest(List<Student> students)
        {
            if (students.Count < 2)
            {
                Console.WriteLine("Not enough students");
                return;
            }

            // Descending Sort
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

            Console.WriteLine($"\nSecond Highest:");
            Console.WriteLine($"{students[1].Name} - {students[1].Score}");
        }

        // Group Students Pass/Fail
        static void GroupStudents(List<Student> students)
        {
            List<Student> passed = new List<Student>();
            List<Student> failed = new List<Student>();

            foreach (Student s in students)
            {
                if (s.Score >= 50)
                {
                    passed.Add(s);
                }
                else
                {
                    failed.Add(s);
                }
            }

            Console.WriteLine("\nPassed Students:");

            foreach (Student s in passed)
            {
                Console.WriteLine($"{s.Name} - {s.Score}");
            }

            Console.WriteLine("\nFailed Students:");

            foreach (Student s in failed)
            {
                Console.WriteLine($"{s.Name} - {s.Score}");
            }
        }

        // Display All Students
        static void DisplayAll(List<Student> students)
        {
            Console.WriteLine("\nAll Students:");

            foreach (Student s in students)
            {
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}, Score: {s.Score}");
            }


            //ArrayList list = new ArrayList();

            //list.Add(10);
            //list.Add(20);
            //list.Add("Arya");

            //int sum = 0;

            //foreach (var item in list)
            //{
            //    if (item is int)
            //    {
            //        sum = sum + (int)item;
            //    }
            //}

            //Console.WriteLine("Sum = " + sum);

            //ArrayList lists = new ArrayList();

            //lists.Add(10);
            //lists.Add(50);
            //lists.Add(20);

            //int max = 0;

            //foreach (var item in lists)
            //{
            //    if (item is int)
            //    {
            //        if ((int)item > max)
            //        {
            //            max = (int)item;
            //        }
            //    }
            //}

            //Console.WriteLine("Maximum = " + max);

            //SearchStudent
                
                ArrayList list = new ArrayList();

            list.Add(10);
            list.Add(20);

            if (list.Contains(20))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }


        }
    }

    }


    
