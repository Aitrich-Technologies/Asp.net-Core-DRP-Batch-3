
using System.Reflection.Metadata;

namespace Gen_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //List<string> list = new List<string>();
            //list.Add("MARCH");
            //list.Add("April");
            //list.Add("June");


            //list.Remove("April");

            //list.Insert(1, "March");

            //Console.WriteLine(list.Contains);

            //Console.WriteLine("total items"+list.Count);

            //list.Sort();
            //foreach (string item in list) { Console.WriteLine(item); }




            //Dictionary<int,string> list = new Dictionary<int,string>();
            //list.Add(1234,"MARCH");
            //list.Add(2345,"April");
            //list.Add(4567,"June");

            //Console.WriteLine("userdetails");
            //foreach (KeyValuePair<int, string> users in list) 
            //{
            //    Console.WriteLine($"user ID:{users.Key},name:{users.Value}");
            //}


            


            Queue <string>queue = new Queue<string>();
            queue.Enqueue("maya");
            queue.Enqueue("mayoora");
            queue.Enqueue("mereena");


            queue.Dequeue();

            Console.WriteLine("credentials");
            foreach (string item in queue) { Console.WriteLine($"names:{queue}"); }



        }
    }
}
