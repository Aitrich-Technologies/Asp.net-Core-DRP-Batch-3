namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] sales = new double[7];
            double total = 0, average;
            double highest, lowest;
            int highDay = 0, lowDay = 0;
            Console.WriteLine("Enter your datas");

            for (int i = 0; i < sales.Length; i++)
            {
                Console.Write("Day " + (i + 1) + ": ");
                sales[i] = Convert.ToDouble(Console.ReadLine());
                total += sales[i];
            }
            average = total / 7;

            highest = sales[0];
            lowest = sales[0];

            for (int i = 1; i < 7; i++)
            {
                if (sales[i] > highest)
                {
                    highest = sales[i];
                    highDay = i;
                }

                if (sales[i] < lowest)
                {
                    lowest = sales[i];
                    lowDay = i;
                }
            }
            Console.WriteLine("\nTotal Sales: " + total);
            Console.WriteLine("Average Sales: " + average);
            Console.WriteLine("Highest Sales: " + highest + " on Day " + (highDay + 1));
            Console.WriteLine("Lowest Sales: " + lowest + " on Day " + (lowDay + 1));
        }
    }
}
