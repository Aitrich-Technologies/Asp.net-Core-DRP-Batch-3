
using System.Collections;
using System.ComponentModel.Design;
namespace Ac_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //ArrayList list = new ArrayList();
            //list.Add("ARYA");
            //list.Add("sanjay");
            //list.Add("Alfin");
            //list.Add("Appu");
            //list.Add("Rahul");



            //foreach (var item in list)
            //{ Console.WriteLine(item); }




            //    ArrayList data = new ArrayList();
            //    data.Add("Mariya");
            //    data.Add(24);
            //    data.Add(92);


            //    data.Add("Rahul");
            //    data.Add(26);
            //    data.Add(85);

            //    data.Add("Arathy");
            //    data.Add(28);
            //    data.Add(75);

            //    data.Remove("Mariya");


            //Console.WriteLine( data);

            //    Console.WriteLine("student names");

            //    foreach (var item in data)

            //        if (item is string) { 
            //            Console.WriteLine(item);
            //        }






            //ArrayList marks= new ArrayList();
            //marks.Add(50);
            //marks.Add(70);
            //marks.Add(90);


            //int max = int.MinValue;
            //foreach (int mark in marks)
            //{

            //    if (mark > max)
            //    {
            //        max = mark;
            //    }

            //}
            //Console.WriteLine("highest mark"+max);





            //Hashtable ht = new Hashtable();
            //ht.Add(1, "Raihan");
            //ht.Add(2, "Mariya");
            //ht.Add(3, "BABY");

            //foreach (var item in ht) 
            //{ Console.WriteLine(item); }




            //Hashtable ht = new Hashtable();
            //ht.Add(1, "Raihan");
            //ht.Add(2, "Mariya");
            //ht.Add(3, "BABY");
            //Console.WriteLine("Enter student ID to search:");

            //int id =Convert .ToInt32(Console.ReadLine());

            //if (ht.ContainsKey(id))
            //{
            //    Console.WriteLine("student found:" + ht[id]);
            //}

            //else { Console.WriteLine("student ID not found"); }




            //Hashtable ht = new Hashtable();
            //ht.Add(1, "Raihan");
            //ht.Add(2, "Mariya");
            //ht.Add(3, "BABY");
            //Console.WriteLine("Enter student ID to update:");

            //int id = Convert.ToInt32(Console.ReadLine());

            //if (ht.ContainsKey(id))
            //{
            //    Console.WriteLine("Enter new name:");
            //    string newName= Console.ReadLine();
            //    ht[id]=newName;
            //    Console.WriteLine("updated successfully");
            //}

            //else { Console.WriteLine("student ID not found"); }




            // Hashtable users = new Hashtable();
            // users.Add("Raihan","2345");
            // users.Add("Mariya","abcd");

            // Console.Write("Enter username:");
            //string username= Console.ReadLine();

            // Console.Write("Enter password");
            // string password= Console.ReadLine();



            // if (users.ContainsKey(username)&& users[username].ToString()==password)
            // {
            //     Console.WriteLine("Login successfull:");


            // }

            // else { Console.WriteLine("invalid username or password"); }

            //stack

            //Stack Assignments = new Stack();
            //Assignments.Push(1);
            //Assignments.Push(2);
            //Assignments.Push(3);

            //Console.WriteLine("last submitted Assignment:" + Assignments.Peek());
            //foreach (var item in Assignments) { Console.WriteLine(item); }


            //reversed

            //string name = "mariya";
            //Stack stack = new Stack();
            //foreach (char c in name)
            //{ 
            //    stack.Push(c);
            //}
            //string reversed = "";
            //while (stack.Count > 0)
            //{
            //    reversed += stack.Pop();
            //}
            //Console.WriteLine("Reversed Name:"+reversed);

            //Queue

            //Queue student = new Queue();
            //student.Enqueue("Rahul");
            //student.Enqueue("Asif");
            //student.Enqueue("Tins");

            //Console.WriteLine("Attendance proccessing");
            //while (student.Count > 0) ;

            //foreach (var item in student) { Console.WriteLine(item); }
            //Console.WriteLine(student.Dequeue());


            //helpdesk

            //Queue doubts= new Queue();
            //doubts.Enqueue("mariya-science doubt");
            //doubts.Enqueue("alfin-english doubt");
            //doubts.Enqueue("sanjay-math doubt");

            //Console.WriteLine("solving doubts:");
            //while (doubts.Count > 0) ;
            //{ 
            //    Console.WriteLine("solved:"+doubts.Dequeue());
            //}
            //    foreach (var item in doubts) { Console.WriteLine(item); }







            //SortedList

            //SortedList student = new SortedList();
            //student.Add(2, "Maya");
            //student.Add(1, "Megha");
            //student.Add(3, "Meghana");



            //Console.WriteLine("Students Sorted by ID:" );


            //foreach (var item in student) { Console.WriteLine(item); }



           //ranklist
            
            SortedList rankList = new SortedList();

            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter rank: ");
                int rank = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter student name: ");
                string name = Console.ReadLine();

                rankList.Add(rank, name);
            }

            Console.WriteLine("\nRank List:");
            foreach (DictionaryEntry item in rankList)
            {
                Console.WriteLine("Rank " + item.Key + " : " + item.Value);
            }
        }
    }
}


















































    
    

