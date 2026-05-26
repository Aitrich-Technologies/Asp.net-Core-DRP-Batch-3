using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericsample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> name = new List <string> ();
            name.Add("arya");
            name.Add("sanjay");
            name.Add("alfin");
            //name.RemoveAt (0);
            Console.WriteLine(name.Contains("arya"));
            name.Sort ();


            foreach (string s in name)
            {
                Console.WriteLine(s);
 
            }

            Dictionary<int,string> fruits = new Dictionary<int,string> ();
            fruits.Add(1,"plum");
            fruits.Add(2,"apple");
            Console.WriteLine("fruits");

            foreach(KeyValuePair<int,string> f in fruits)
            {
                Console.WriteLine($"fruitid:{ f.Key}, fruit: { f.Value} " );

            }



        }

      
    }
}
