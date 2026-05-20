namespace oneD_Array
{
    {
    internal class Program
    {
        static void Main(string[] args)
        {
            //q1


            //int[] numbers = { 30, 60, 90 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //q2

            //int[] numbers = { 30, 60, 90 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine("sum=" + sum);

            //q3

            //int[] numbers = { 30, 60, 90 };
            //int max = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}
            //Console.WriteLine("Biggest number=" + max);

            //q4

            //int[] numbers = { 30, 60, 90 };

            //Console.WriteLine("Total elements = " + numbers.Length);


            //Question 5

            int[] numbers = { 20, 40, 60 };

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
