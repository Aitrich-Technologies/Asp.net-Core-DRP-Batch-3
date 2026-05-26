using System.ComponentModel;

namespace EH1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int result = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("value cannot be zero");
            }

            finally {
                Console.WriteLine("completed");

            }

        }
    }
}
