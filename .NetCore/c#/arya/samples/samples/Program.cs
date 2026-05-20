using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace samples
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int i = 0;
//            string[] jobs = new string[10];
//            Console.WriteLine("Enter the no of jobs posted ?");
//            int count = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter Jobs");
//            while (count != i)
//            {
//                jobs[i] = Convert.ToString(Console.ReadLine());
//                i++;
//            }
//            Console.WriteLine("===========");
//            for (i = 0; i <= count; i++)
//            {
//                Console.WriteLine(jobs[i]);
//            }
//            Console.ReadLine();
//        }
//    }
//}
//namespace samples
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//            string[] roles = new string[5];
//            roles[0] = "company member";
//            roles[1] = "admin";
//            roles[2] = "customer";
//            roles[3] = "customer1";
//            roles[4] = "consultant";
//            for (int i = 0; i < roles.Length; i++)
//            {
//                Console.WriteLine(roles[i]);
//            }
//            Console.ReadLine();
//        }
//    }
//}
namespace samples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] roles = new string[2, 2];
            roles[0, 0] = "JobProvider";
            roles[0, 1] = "Admin";
            roles[1, 0] = "JobSeeker";
            roles[1, 1] = "CompanyMember";
            //traversal
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(roles[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}