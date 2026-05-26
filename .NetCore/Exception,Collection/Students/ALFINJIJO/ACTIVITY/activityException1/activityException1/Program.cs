using System.Data;
using System.Linq.Expressions;

namespace activityException1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can,t divisible by 0");

            }
            catch (FormatException)
            {
                Console.WriteLine("enter only number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("number is over ");
            }
            int age = 15;
            try
            {
                if (age < 18)
                {
                    throw new AgeException("age  18 or above");
                }
                Console.WriteLine("eligible");
            }
            catch (AgeException ex)
            {
                Console.WriteLine("ex.message");
            }

        }
    }
}
