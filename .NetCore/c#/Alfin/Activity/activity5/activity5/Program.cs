using System.ComponentModel;

namespace activity5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while loop q1
            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine(i);i++;
            //}
            //while loop q2
            //int num = 0;
            //int sum = 0;
            //Console.WriteLine("enter nubers (0 to stop):");
            //while(true)
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if (num == 0)
            //        break;
            //    sum += num;
            //}
            //Console.WriteLine("total sum =" + sum);

            //whuile loop q3

            //int correctpin = 1234;
            //int enteredpin = 0;
            //while (correctpin != enteredpin)
            //{
            //    Console.WriteLine("enter pin:");
            //    enteredpin = Convert.ToInt32(Console.ReadLine());
            //    if (correctpin != enteredpin)
            //    {
            //        Console.WriteLine("in correct pin. try again.");

            //    }
            //}
            //Console.WriteLine("access granted");

            //for loop q1

            //int num = 5;

            //for (int i = 1; i <= 10; i++)
            //    {
            //        Console.WriteLine(num + " x " + i + " = " + (num * i));
            //    }

            //for loop q2

            //int num = 5;
            //int fact = 1;
            //for (int i = 1; i <= num; i++) {
            //    fact *=i;
            //}
            //Console.WriteLine("factorial =" + fact);

            //for loop q3

            //int total = 0;
            //int mark;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("enter mark" +i+ ":");
            //    mark = Convert.ToInt32(Console.ReadLine());
            //    total += mark;

            //}
            //Console.WriteLine("total marks =" + total);


            //do while loop q1


            //int n = 0;
            //int i = 0;

            //Console.WriteLine("enter number of jobs:");
            //n = Convert.ToInt32(Console.ReadLine());
            //string[] jobs = new string[n];
            //jobs[0] = "developer";
            //jobs[0] = "designer";
            //jobs[0] = "tester";
            //do
            //{
            //    Console.Write("Enter job name " + (i + 1) + ": ");
            //    i = Convert.ToInt32(Console.ReadLine());
            //    i++;
            //} while (i < n);


            //Console.WriteLine("\nJob List:");
            //i = 0;
            //do
            //{
            //    Console.WriteLine(jobs[i]);
            //    i++;
            //} while (i < n);

            //do while loop q2

        //    string username, password;

        //do
        //{
        //    Console.Write("Enter Username: ");
        //    username = Console.ReadLine();

        //    Console.Write("Enter Password: ");
        //    password = Console.ReadLine();

        //    if (username != "admin" || password != "1234")
        //    {
        //        Console.WriteLine("Invalid login! Try again.\n");
        //    }

        //} while (username != "admin" || password != "1234");

        //    Console.WriteLine("Login Successful!");

            //for each q1 

            string[] students = { "alfin", "sanjay", "mariya", "arya" };
            foreach (string name in students)
            {
                Console.WriteLine(name);
            }

            //for each q2

            string[] jobs = { "Developer", "Accountant", "Teacher", "scientist" };

            foreach (string job in jobs)
            {
                Console.WriteLine(job);
            }
                //Question 10

                string[] fruits = { "Apple", "strawberry", "litchi", "orange" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }




        }
    }
}
