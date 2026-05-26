namespace Enum
{
    enum Days
    {
        Sunday,     
        Monday,     
        Tuesday,    
        Wednesday,  
        Thursday,  
        Friday,     
        Saturday    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Days today = Days.Wednesday;
            Console.WriteLine("Day Name: " + today);


        }

    }
}
}
