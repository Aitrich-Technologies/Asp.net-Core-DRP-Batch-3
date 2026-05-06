

using System.Collections;


namespace Clctn1



    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("ARYA");
            list.Add("sanjay");
            list.Add("Alfin");

            foreach (var item in list)
            { 
                Console.WriteLine(item);
            }


        }
    }
}
