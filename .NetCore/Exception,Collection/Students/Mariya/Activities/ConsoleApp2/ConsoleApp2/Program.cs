using System.Collections;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();
            //list.Add("ARYA");
            //list.Add("sanjay");
            //list.Add("Alfin");


            //list.Remove("ARYA");
            //list.RemoveAt(1);
            //list.Insert(1,"Raihan");
            //int Index = list.IndexOf(1);
            //Console.WriteLine($"index is"+Index);
            //Console.WriteLine("Total items" +list.Count);

            //bool renai = list.Contains("sanjay");
            //Console.WriteLine(renai);


            //list.Sort();

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Hashtable ht = new Hashtable();
            //ht.Add(1, "Raihan");
            //ht.Add(2, "Mariya");
            //ht.Add(3, "BABY");

            //ht.Remove(2);

            //Console.WriteLine(ht.ContainsKey(2));
            //Console.WriteLine(ht.ContainsValue("BABY"));


            //foreach (var item in ht) 
            //{ Console.WriteLine(item); }


            //Queue queue=new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);


            //queue.Dequeue();

            //Console.WriteLine("totalitems" + queue.Count);
            //foreach (var item in queue) { Console.WriteLine(item); }




            { 
                Stack s=new Stack();
                s.Push(1);
                s.Push(2);
                s.Push(3);

                s.Pop();

                Console.WriteLine("total items" + s.Count);
                foreach (var item in s) { Console.WriteLine(item); }

            }


            SortedList sl=new SortedList();
            sl.Add(2, "Maya");
            sl.Add(1, "Megha");
            sl.Add(3, "Meghana");

            sl.Remove(2);

            Console.WriteLine("totalitems"+sl.Count);
            Console.WriteLine(sl.ContainsValue(2));
            Console.WriteLine(sl.IndexOfValue("Megha"));

            foreach (var item in sl) {  Console.WriteLine(item); }

           
            

        }
    }
}
