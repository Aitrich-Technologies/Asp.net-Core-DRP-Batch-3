namespace Array_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    //1D Array
            //    string[] roles = new string[4];
            //    // Assigning values to array elements
            //    roles[0] = "CompanyMember";
            //    roles[1] = "JobSeeker";
            //    roles[2] = "JobProvider";
            //    roles[3] = "Admin";
            //    // Iterating over array elements using a loop
            //    for (int i = 0; i < roles.Length; i++)
            //    {
            //        Console.WriteLine(roles[i]);
            //    }
            //    Console.ReadLine();


            //2D Array
            //string[,] roles = new string[2, 2];
            //roles[0, 0] = "JobProvider"; //initialization
            //roles[0, 1] = "Admin";
            //roles[1, 0] = "JobSeeker";
            //roles[1, 1] = "CompanyMember";
            ////traversal
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(roles[i, j] + " ");
            //    }
            //    Console.WriteLine(); //new line at each row
            //}
            //Console.ReadLine();



            //Jagged Array
            string[][] roles = new string[2][];
            // Initialize the array
            roles[0] = new string[] { "JobProvider" };
            roles[1] = new string[] { "JobSeeker","JobProvider","CompanyMember" };

            // Traverse array elements
            for (int i = 0; i < roles.Length; i++)
            {
                for (int j = 0; j < roles[i].Length; j++)
                {
                    System.Console.Write(roles[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
