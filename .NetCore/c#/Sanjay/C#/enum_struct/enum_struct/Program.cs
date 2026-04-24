namespace enum_struct
{
    //public enum days
    //{
    //    Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    //}

    public struct vehicle
    {
        public int id;
        public string Name;
        public string Brand;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //days day = days.Monday;
            //Console.WriteLine(day);
            //Console.WriteLine((int)day);


            vehicle vehi;
            vehi.id = 0;
            vehi.Name = "XC900";
            vehi.Brand = "Volvo";

            Console.WriteLine(vehi.id);
            Console.WriteLine(vehi.Name);
            Console.WriteLine(vehi.Brand);


        }
    }
}
