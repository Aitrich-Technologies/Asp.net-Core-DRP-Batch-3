using System.Collections;

namespace Activity
{
    internal class Program
    {
        static void Main(string[] args)
        //{
        //    SortedList sl = new SortedList();
        //    sl.Add(1, "Arya");
        //    sl.Add(3, "Alfin");
        //    sl.Add(2, "Mariya");

        //    foreach (var i in sl)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //{
        //    SortedList sl = new SortedList();
        //    sl.Add(1, "Arya");
        //    sl.Add(3, "Alfin");
        //    sl.Add(2, "Mariya");
        //    //Console.WriteLine(sl.GetValueList());
        //    foreach (DictionaryEntry i in sl)
        //    {
        //        Console.WriteLine("Rank: " + i.Key + " Name:" + i.Value);
        //    }
        //}

        //{
        //    Stack stack = new Stack();

        //    stack.Push("Assignment_1");
        //    stack.Push("Assignment_3");
        //    stack.Push("Assignment_2");
        //    stack.Push("Assignment_5");
        //    stack.Push("Assignment_4");


        //    Console.WriteLine("Last submitted assignment : " + stack.Peek());
        //}

        //{
        //    string name = "Alfin";
        //    Stack stack = new Stack();

        //    foreach (var item in name)
        //    {
        //        stack.Push(item);
        //    }
        //    string reversedItem = " ";
        //    while(stack.Count > 0) 
        //    {
        //        reversedItem += stack.Pop();
        //        //Console.WriteLine(item);
        //    }
        //    Console.WriteLine(reversedItem);
        //}



        //    {
        //        Queue attendanceQueue = new Queue();

        //        attendanceQueue.Enqueue("Arya");
        //        attendanceQueue.Enqueue("Alfin");
        //        attendanceQueue.Enqueue("Mariya");

        //        Console.WriteLine("Attendance:\n");

        //        while (attendanceQueue.Count > 0)
        //        {
        //            string student = Convert.ToString( attendanceQueue.Dequeue());
        //            Console.WriteLine(student + " - Present");
        //        }

        //}


        //{
        //    Queue Doubt = new Queue();

        //    Doubt.Enqueue("Alfin - OOP doubt");
        //    Doubt.Enqueue("Arya - Array issue");
        //    Doubt.Enqueue("Mariya - All doubt");

        //    Console.WriteLine("Solving Doubts:\n");

        //    while (Doubt.Count > 0)
        //    {
        //        string query =Convert.ToString( Doubt.Dequeue());
        //        Console.WriteLine("Solved: " + query);
        //    }
        //}

        //{
        //    ArrayList arrayList = new ArrayList();
        //    arrayList.Add( "Arya");
        //    arrayList.Add( "Alfin");
        //    arrayList.Add( "Mariya");
        //    arrayList.Add("Someone");
        //    arrayList.Add("someone_2.0");

        //    foreach (var i in arrayList)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //{
        //    ArrayList arrayList = new ArrayList();
        //    arrayList.Add(1);
        //    arrayList.Add("Alfin");
        //    arrayList.Add(40);
        //    arrayList.Add(2);
        //    arrayList.Add("Arya");
        //    arrayList.Add(30);

        //    foreach (var item in arrayList)
        //    {
        //        if (item is string)
        //        {
        //            Console.WriteLine(item);
        //        }
        //    }
        //}


        //{
        //    ArrayList arrayList = new ArrayList();
        //    arrayList.Add(10);
        //    arrayList.Add(40);
        //    arrayList.Add(20);
        //    arrayList.Add(30);

        //    int max = (int)arrayList[0];

        //    foreach (var item in arrayList)
        //    {
        //        int value = (int)item;

        //        if (value > max)
        //        {
        //            max = value;
        //        }
        //    }

        //    Console.WriteLine("Highest Mark: " + max);
        //}


        //{
        //    ArrayList students = new ArrayList();

        //    students.Add("Alfin");
        //    students.Add("Arya");
        //    students.Add("Mariya");

        //    students.Remove("Rahul");

        //    Console.WriteLine("Updated Student List:\n");

        //    foreach (var student in students)
        //    {
        //        Console.WriteLine(student);
        //    }
        //}

        //{
        //    Hashtable students = new Hashtable();

        //    students.Add(101, "Alfin");
        //    students.Add(102, "Arya");
        //    students.Add(103, "Mariya");

        //    Console.WriteLine("Student List:\n");

        //    foreach (DictionaryEntry item in students)
        //    {
        //        Console.WriteLine("ID: " + item.Key + " - Name: " + item.Value);
        //    }

        //    int Id = 102;

        //    if (students.ContainsKey(Id))
        //    {
        //        Console.WriteLine("Student Found: " + students[Id]);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Student ID not found");
        //    }
        //}


        //{
        //    Hashtable students = new Hashtable();

        //    students.Add(101, "Alfin");
        //    students.Add(102, "Arya");
        //    students.Add(103, "Mariya");

        //    Console.WriteLine("Student List:\n");

        //    foreach (DictionaryEntry item in students)
        //    {
        //        Console.WriteLine("ID: " + item.Key + " - Name: " + item.Value);
        //    }

        //    int Id = 103;

        //    if (students.ContainsKey(Id))
        //    {
        //        students[Id] = "Someone"; 
        //        Console.WriteLine("Updated Successfully");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Student ID not found");
        //    }

        //    Console.WriteLine("Updated list\n");
        //    foreach (DictionaryEntry item in students)
        //    {
        //        Console.WriteLine("ID: " + item.Key + " - Name: " + item.Value);
        //    }
        //}

        {
            Hashtable users = new Hashtable();

            users.Add("Sanjay", "1234");
            users.Add("Alfin", "abcd");
            users.Add("someone", "hehe");

            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();


            if (users.ContainsKey(username))
            {
                if (users[username].ToString() == password)
                {
                    Console.WriteLine("Login Successful");
                }
                else
                {
                    Console.WriteLine("Invalid Password");
                }
            }
            else
            {
                Console.WriteLine("Username not found ");
            }
        }
    }
}