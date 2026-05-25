using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList student = new ArrayList();
            student.Add("Anu");
            student.Add("Devu");
            student.Add("Jency");
            student.Add("Anjitha");
            student.Add("Archa");

            foreach (var item in student)
            {
                Console.WriteLine(item);
            }

            ArrayList filter = new ArrayList();
            filter.Add("Anu");
            filter.Add(20);
            filter.Add(80);

            filter.Add("Devu");
            filter.Add(22);
            filter.Add(100);

            filter.Add("Jency");
            filter.Add(25);
            filter.Add(70);

            Console.WriteLine("only students name");
            foreach (var name in filter)
            {
                if (name is string)
                {
                    Console.WriteLine(name);
                }
            }

            ArrayList mark = new ArrayList();
            mark.Add(100);
            mark.Add(80);
            mark.Add(90);

            int max = 0;

            foreach (int item in mark)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            Console.WriteLine("Highest Marks: " + max);

            student.Remove("Anu");

            Console.WriteLine("updated student list");

            foreach (var item in student)
            {
                Console.WriteLine(item);
            }

            //Hashtable
            Hashtable students = new Hashtable();

            students.Add(1, "Anu");
            students.Add(2, "Devu");
            students.Add(3, "Jency");

            Console.WriteLine("All Students:");
            foreach (DictionaryEntry s in students)
            {
                Console.WriteLine("ID: " + s.Key + " Name: " + s.Value);
            }

            int SearchId = 3;
            if (students.ContainsKey(SearchId))
            {
                Console.WriteLine("student found:" + students[SearchId]);
            }
            else
            { Console.WriteLine("student not found"); }

            int updatedId = 4;

            if(!students.ContainsKey(updatedId))
            {
                students[updatedId] = "Archa"; 
            Console.WriteLine("Updated Student: " + students[updatedId]);
            }

            Hashtable login = new Hashtable();
            login.Add("Anju",100);
            login.Add("devu", 101);

            string username = "Anju";
            int password = 100;

            if (login.ContainsKey(username) && login[username].Equals(password))
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Invalid Login");
            }

            Stack assignments = new Stack();
            assignments.Push("maths");
            assignments.Push("social");
            assignments.Push("science");

            Console.WriteLine("last submitted assignment");
            Console.WriteLine(assignments.Peek());

            string Name = "ANU";

            Console.Write("Reversed Name: ");
            for (int i = Name.Length - 1; i >= 0; i--)
            {
                Console.Write(Name[i]);
            }
            Console.WriteLine();

           

            Queue helpDesk = new Queue();
            helpDesk.Enqueue("Doubt 1");
            helpDesk.Enqueue("Doubt 2");
            helpDesk.Enqueue("Doubt 3");

            Console.WriteLine("Help Desk Processing:");
            while (helpDesk.Count > 0)
            {
                Console.WriteLine(helpDesk.Dequeue());
            }

            //sortedlisted

            SortedList sl= new SortedList();
            sl.Add(3, "Jency");
            sl.Add(1, "Anu");
            sl.Add(2, "Devu");

            Console.WriteLine("Students Sorted by ID:");
            foreach (DictionaryEntry s in sl)
            {
                Console.WriteLine("ID: " + s.Key + " Name: " + s.Value);
            }

            SortedList ranklist = new SortedList();
            ranklist.Add(2, "Devu");
            ranklist.Add(1, "Anu");
            ranklist.Add(3, "Jency");

            Console.WriteLine("\nRank List:");
            foreach (DictionaryEntry r in ranklist)
            {
                Console.WriteLine("Rank: " + r.Key + " Name: " + r.Value);
            }



        }
    }
        
    }
        
    

