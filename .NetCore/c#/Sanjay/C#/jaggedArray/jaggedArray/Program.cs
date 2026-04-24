namespace jaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jagged array

            //q1

            int[][] numbers = new int[2][];

            numbers[0] = new int[] { 10, 20 };
            numbers[1] = new int[] { 30, 40, 50 };

            Console.WriteLine("Jagged Array Values:");


            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write(numbers[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            //Q2

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


            //Q3

            //int[][] numbers = new int[2][];

            //numbers[0] = new int[] { 10, 20 };
            //numbers[1] = new int[] { 30, 40, 50 };

            //Console.WriteLine("Total rows = " + numbers.Length);

            //Console.ReadLine();

            //Q4

            //int[][] numbers = new int[2][];

            //numbers[0] = new int[] { 10, 20 };
            //numbers[1] = new int[] { 30, 40, 50 };

            //Console.WriteLine("Second row values:");

            //for (int j = 0; j < numbers[1].Length; j++)
            //{
            //    Console.WriteLine(numbers[1][j]);
            //}

            //Console.ReadLine();

            //Q5

            //int[][] numbers = new int[2][];

            //numbers[0] = new int[] { 10, 20 };
            //numbers[1] = new int[] { 30, 40, 50 };

            //int total = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    total += numbers[i].Length;
            //}

            //Console.WriteLine("Total elements = " + total);

            //Console.ReadLine();
        }
    }
}
