//namespace Index
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//}



internal class Program
{
    static void Main()
    {
        int i = 1;

        while (i <= 10)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}





//class Program
//{
//    static void Main()
//    {
//        int num, sum = 0;

//        Console.WriteLine("Enter numbers (0 to stop):");

//        while (true)
//        {
//            num = int.Parse(Console.ReadLine());

//            if (num == 0)
//                break;

//            sum += num;
//        }

//        Console.WriteLine("Total Sum: " + sum);
//    }
//}

////class Program
////{
////    static void Main()
////    {
////        int correctPin = 1234;
////        int pin;

////        while (true)
////        {
////            Console.Write("Enter PIN: ");
////            pin = int.Parse(Console.ReadLine());

////            if (pin == correctPin)
////            {
////                Console.WriteLine("Access Granted");
////                break;
////            }
////            else
////            {
////                Console.WriteLine("Wrong PIN, try again");
////            }
////        }
////    }
////}

//using System;

////class Program
////{
////    static void Main()
////    {
////        int num = 5;

////        for (int i = 1; i <= 10; i++)
////        {
////            Console.WriteLine(num + " x " + i + " = " + (num * i));
////        }
////    }
////}


//using System;

////class Program
////{
////    static void Main()
////    {
////        int num = 5;
////        int fact = 1;

////        for (int i = 1; i <= num; i++)
////        {
////            fact *= i;
////        }

////        Console.WriteLine("Factorial: " + fact);
////    }
////}

//using System;

////class Program
////{
////    static void Main()
////    {
////        int total = 0;

////        for (int i = 1; i <= 5; i++)
////        {
////            Console.Write("Enter mark " + i + ": ");
////            int mark = int.Parse(Console.ReadLine());
////            total += mark;
////        }

////        Console.WriteLine("Total Marks: " + total);
////    }
////}

//using System;

////class Program
////{
////    static void Main()
////    {
////        Console.Write("Enter number of jobs: ");
////        int n = int.Parse(Console.ReadLine());

////        string[] jobs = new string[n];
////        int i = 0;

////        do
////        {
////            Console.Write("Enter job name: ");
////            jobs[i] = Console.ReadLine();
////            i++;
////        }
////        while (i < n);

////        Console.WriteLine("Job List:");
////        foreach (string job in jobs)
////        {
////            Console.WriteLine(job);
////        }
////    }
////}

//using System;

////class Program
////{
////    static void Main()
////    {
////        string username, password;

////        do
////        {
////            Console.Write("Enter Username: ");
////            username = Console.ReadLine();

////            Console.Write("Enter Password: ");
////            password = Console.ReadLine();

////        } while (username != "admin" || password != "1234");

////        Console.WriteLine("Login Successful");
////    }
////}

//using System;

////class Program
////{
////    static void Main()
////    {
////        string[] students = { "Arun", "Bala", "Cathy", "David" };

////        foreach (string name in students)
////        {
////            Console.WriteLine(name);
////        }
////    }
////}

//using System;

////class Program
////{
////    static void Main()
////    {
////        string[] jobs = { "Developer", "Designer", "Tester" };

////        foreach (string job in jobs)
////        {
////            Console.WriteLine(job);
////        }
////    }
////}

//using System;

// internal class Program
//{
//    static void Main()
//    {
//        string[] fruits = { "Apple", "Banana", "Mango", "Orange" };

//        foreach (string fruit in fruits)
//        {
//            Console.WriteLine(fruit);
//        }
//    }
//}