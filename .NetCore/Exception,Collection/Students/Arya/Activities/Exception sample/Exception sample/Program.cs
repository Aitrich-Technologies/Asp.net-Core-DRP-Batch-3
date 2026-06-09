using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_sample
{
    internal class Program
    {

        class AgeException:Exception
        {
         public AgeException(string message): base(message) 
               
                {
            
            }
        }
        static void Main(string[] args)
        {
            //try
            //{
            //    int a = 10;
            //    int b = 0;
            //    int result = a / b;
            //}

            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("cannot divide by 0");
            //}
            //finally
            //{ Console.WriteLine("execution finished"); }

            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    int num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter a number");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    int result = num1 / num2;
            //    Console.WriteLine("Result");
            //}

            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine(" Cannot divide by zero.");
            //}

            //catch (FormatException)
            //{
            //    Console.WriteLine(" Please enter only numbers.");
            //}

            //catch (OverflowException)
            //{
            //    Console.WriteLine(" Number is too large or too small.");
            //}

            //finally
            //{
            //    Console.WriteLine("Program ended.");
            //}

            int age = 15;

            try
            {
                if (age < 18)
                {
                    throw new AgeException("age must be 18 or above");
                }
                Console.WriteLine("eligible");
            }

            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
                
        







    }



            

        }
    }

