using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 1; i <= 5; i++)   
            //{
            //    for (int j = 1; j <= i; j++)  
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //2

            for (int i = 5; i >= 1; i--)   // rows decreasing
            {
                for (int j = 1; j <= i; j++)  // columns
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            //3

            //for (int i = 1; i <= 4; i++)   // rows
            //{
            //    for (int j = 1; j <= i; j++)  // columns
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //4

            // Upper part (increasing)
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //// Lower part (decreasing)
            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //5

            for (int i = 1; i <= 4; i++)   // rows
            {
                for (int j = 1; j <= i; j++)  // columns
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }















        }







        
    }
}
