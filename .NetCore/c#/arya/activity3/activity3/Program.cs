using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question1

            //int[] numbers = { 20, 40, 60 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);

        

        //Question 2

    //    int[] numbers = { 20, 40, 60 };
    //    int sum = 0;
    //    for (int i = 0; i<numbers.Length; i++)
    //    {
    //        sum += numbers[i];
    //    }
    //Console.WriteLine("sum="+ sum);

            //Question 3

            //int[] numbers = { 20, 40, 60 };
            //int max = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}
            //Console.WriteLine("Biggest number=" + max);

            //Question 4

            //int[] numbers = { 10, 20, 30 };

            //Console.WriteLine("Total elements = " + numbers.Length);


            //Question 5

            //int[] numbers = { 20, 40, 60 };

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(numbers[i]);

            //Jagged Array

            //Question 1

            //int[][] numbers = new int[2][];

            //numbers[0] = new int[] { 10, 20 };
            //numbers[1] = new int[] { 30, 40, 50 };

            //Console.WriteLine("Jagged Array Values:");


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.Write(numbers[i][j] + " ");
            //    }
            //    Console.WriteLine(); 
            //}

            //Console.ReadLine(); 

            //Question 2

            //int[][] numbers = new int[2][];

            //numbers[0] = new int[] { 10, 20 };
            //numbers[1] = new int[] { 30, 40, 50 };

            //Console.WriteLine("All values:");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.Write(numbers[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadLine();


            //Question 3

            //int[][] numbers = new int[2][];

            //numbers[0] = new int[] { 10, 20 };
            //numbers[1] = new int[] { 30, 40, 50 };

            //Console.WriteLine("Total rows = " + numbers.Length);

            //Console.ReadLine();

            //Question 4

            //int[][] numbers = new int[2][];

            //numbers[0] = new int[] { 10, 20 };
            //numbers[1] = new int[] { 30, 40, 50 };

            //Console.WriteLine("Second row values:");

            //for (int j = 0; j < numbers[1].Length; j++)
            //{
            //    Console.WriteLine(numbers[1][j]);
            //}

            //Console.ReadLine();

            //Question 5

            int[][] numbers = new int[2][];

            numbers[0] = new int[] { 10, 20 };
            numbers[1] = new int[] { 30, 40, 50 };

            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i].Length;
            }

            Console.WriteLine("Total elements = " + total);

            Console.ReadLine();


        }
    }
    
}
