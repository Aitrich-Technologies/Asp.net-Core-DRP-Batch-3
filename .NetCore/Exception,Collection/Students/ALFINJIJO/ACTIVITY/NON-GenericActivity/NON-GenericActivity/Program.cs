using System.Collections;

namespace NON_GenericActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList array = new ArrayList();
            //array.Add("sanjay");
            //array.Add("mariya");
            //array.Add("arya");
            //array.Add("alen");
            //array.Add("alfin");

            //foreach (var i in array)
            //{
            //    Console.WriteLine(i);
            //}

            //ArrayList array = new ArrayList();
            //array.Add("sanjay");
            //array.Add(20);
            //array.Add(85);
            //array.Add("alfin");
            //array.Add(22);
            //array.Add(90);
            //foreach (var i in array)
            //{
            //    if (i is string)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //ArrayList array = new ArrayList();
            //array.Add(40);
            //array.Add(50);
            //array.Add(60);
            //array.Add(70);
            //array.Add(80);

            //int highest = (int)array[0];
            //foreach (var i in array)
            //{
            //    int value = (int)i;
            //    if(value>highest)
            //    {
            //        highest = value;
            //    }
            //}
            //Console.WriteLine("Highest Mark: " + highest);

            //ArrayList array = new ArrayList();
            //array.Add("Alfin");
            //array.Add("sanjay");
            //array.Add("Alen");

            //array.Remove("arya");

            //Console.WriteLine("Updated Student List:");
            //foreach (var i in array)
            //{
            //    Console.WriteLine(i);
            //}


            //Hashtable student = new Hashtable();
            //student.Add(101, "sanjay");
            //student.Add(102, "mariya");
            //student.Add(103, "arya");
            //student.Add(105, "alfin");
            //Console.WriteLine("student list:");
            //foreach (DictionaryEntry i in student)
            //{
            //    Console.WriteLine("id:" + i.Key + "-name:" + i.Value);
            //}
            //int Id = 102;

            //if (student.ContainsKey(Id))
            //{
            //    Console.WriteLine("Student Found: " + student[Id]);
            //}
            //else
            //{
            //    Console.WriteLine("Student ID not found");
            //}



            //    Hashtable student = new Hashtable();
            //    student.Add(101, "Alfin");
            //    student.Add(102, "Arya");
            //    student.Add(103, "Mariya");

            //    Console.WriteLine("Student List:");

            //    foreach (DictionaryEntry i in student)
            //    {
            //        Console.WriteLine("ID: " + i.Key + " - Name: " + i.Value);
            //    }

            //    int Id = 103;

            //    if (student.ContainsKey(Id))
            //    {
            //        student[Id] = "Someone";
            //        Console.WriteLine("Updated Successfully");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Student ID not found");
            //    }

            //    Console.WriteLine("Updated list");
            //    foreach (DictionaryEntry item in student)
            //    {
            //        Console.WriteLine("ID: " + item.Key + " - Name: " + item.Value);
            //    }
            //}

            Hashtable students = new Hashtable();

            students.Add(101, "Alfin");
            students.Add(102, "sanjay");

            students[102] = "Kevin";   

            foreach (DictionaryEntry student in students)
            {
                Console.WriteLine(student.Key + " - " + student.Value);
            }


            //Hashtable users = new Hashtable();
            //users.Add("sanjay", "1234");
            //users.Add("arya", "abcd");
            //users.Add("mariya", "pass");
            //Console.Write("Enter Username: ");
            //string username = Console.ReadLine();
            //Console.Write("Enter Password: ");
            //string password = Console.ReadLine();
            //if (users.ContainsKey(username))
            //{
            //    if (users[username].ToString() == password)
            //    {
            //        Console.WriteLine("Login Successful");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Password");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Username not found");
            //}


            //Stack s = new Stack();
            //s.Push("maths assignment");
            //s.Push("social asssignment");
            //s.Push("science assignment");
            //Console.WriteLine("last submitted assignment:" + s.Peek());





            //string name = "sanjay";
            //Stack stack = new Stack();

            //foreach (var item in name)
            //{
            //    stack.Push(item);
            //}
            //string reversedItem = " ";
            //while (stack.Count > 0)
            //{
            //    reversedItem += stack.Pop();

            //}
            //Console.WriteLine(reversedItem);



            //Queue s = new Queue();
            //s.Enqueue("sanjay");
            //s.Enqueue("arya");
            //s.Enqueue("Mariya");
            //Console.WriteLine("Attendance order:");
            //while (s.Count > 0)
            //{
            //    string student = Convert.ToString(s.Dequeue());
            //    Console.WriteLine(student + " - Present");
            //}




            //Queue doubts = new Queue();
            //doubts.Enqueue("tech issue");
            //doubts.Enqueue("project doubt");
            //doubts.Enqueue("problem help");
            //Console.WriteLine("solving doubt:");
            //while (doubts.Count > 0)
            //{
            //    string query = Convert.ToString(doubts.Dequeue());
            //    Console.WriteLine("solved: " + query);
            //}



            //SortedList sl = new SortedList();
            //sl.Add(1, "sanjay");
            //sl.Add(2, "arya");
            //sl.Add(3, "mariya");
            //Console.WriteLine("Sorted student :");
            //foreach(var i in sl)
            //{
            //    Console.WriteLine(i);
            //}



            //SortedList sl = new SortedList();
            //    sl.Add(2, "sanjay");
            //    sl.Add(1, "arya");
            //    sl.Add(3, "mariya");
            //    Console.WriteLine("student rank list:");
            //    foreach (DictionaryEntry i in sl)
            //    {
            //        Console.WriteLine("Rank:" + i.Key + "name:" + i.Value);
            //    }

            //List<string> array = new List<string>();
            //array.Add("sanjay");
            //array.Add("mariya");
            //array.Add("arya");
            //array.Add("alen");
            //array.Add("alfin");
            ////array.Remove("mariya");
            //array.RemoveAt(4);
            //array.Insert(1, "alfin");
            //Console.WriteLine(array.Contains("alfin"));
            //Console.WriteLine(array.Count);
            //array.Sort();


            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);

            //}

            //Hashtable hash = new Hashtable();
            //hash.Add(100, "sanjay-3day-Rs.3000");
            //hash.Add(101, "arya-3day-Rs.6000");
            //hash.Add(102, "mariya-3day-Rs.5000");
            //hash.Remove(100);
            //Console.WriteLine(hash.ContainsValue("arya-3day-Rs.6000"));
            //Console.WriteLine(hash.ContainsKey(101));
            //Console.WriteLine(hash.Count);


            //foreach (DictionaryEntry i in hash)
            //{

            //    Console.WriteLine("tour id:" + i.Key+i.Value);

            //        }
            //Queue Q = new Queue();
            //Q.Enqueue( "sanjay");
            //Q.Enqueue("mariya");
            //Q.Enqueue("arya");
            //foreach (var item in Q)
            //{

            //}

            //Dictionary<int,string> D= new Dictionary<int,string>();
            //D.Add(100, "applle");
            //D.Add(102, "goat");
            //D.Add(103, "messi");

            //D.Clear();
            ////D.Remove(100);


            //foreach (var item in D)
            //{
            //    Console.WriteLine(item);
            //}
            //SortedList<int, string> s= new SortedList<int, string>();
            //s.Add(100, "applle");
            //s.Add(102, "goat");
            //s.Add(103, "messi");

            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}







        }
        
    }
}
