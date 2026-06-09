using System;
using System.Collections;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activitycollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Arya");
            list.Add("Sanjay");
            list.Add("mariya");
            ////list.RemoveAt(0);
            //list.Remove("mariya");
            //list.Insert(1, "anu");
            ////var name = list.IndexOf("anu");
            //list.Sort();
            //Console.WriteLine(list.Count);
            ////Console.WriteLine(name);
            //bool name = list.Contains(list[0]);
            //Console.WriteLine(name);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Hashtable ht = new Hashtable();
            //ht.Add(1, "Tulip");
            //ht.Add(2,"Rose");
            //ht.Add(3,"Daliya");
            ////ht.Remove(1);
            //ht.Add(4, "marigold");

            //Console.WriteLine(ht.ContainsValue("Rose"));
            //Console.WriteLine(ht.ContainsKey(1));



            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}

            // Queue fruits = new Queue();
            // fruits.Enqueue("apple");
            // fruits.Enqueue("orange");
            // fruits.Enqueue("plum");
            // fruits.Dequeue();

            //Console.WriteLine( fruits.Peek());
            // Console.WriteLine(fruits.Count);
            // Console.WriteLine(fruits.Contains(2));


            // foreach (var item in fruits)
            // {
            //     Console.WriteLine(item);

            // }

            //Stack number = new Stack();
            //number.Push(1);
            //number.Push(2);
            //number.Push(3);
            ////number.Pop();

            //Console.WriteLine(number.Peek());
            //Console.WriteLine(number.Contains(2));

            //foreach (var item in number)
            //{
            //    Console.WriteLine(item);
            //}

           // SortedList s = new SortedList();
           // s.Add(3,"arya");
           // s.Add(1, "alfin");
           // s.Add(2, "sanjay");
           //Console.WriteLine( s.ContainsValue("alfin"));
           //Console.WriteLine( s.ContainsKey(2));

           // foreach (DictionaryEntry item in s) 
           // {
           //     Console.WriteLine(item.Key + "-" + item.Value);
           // }


        }
    }
}