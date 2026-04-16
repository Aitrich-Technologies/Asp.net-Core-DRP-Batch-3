using System.Xml.Schema;

namespace activityenum2
{
    public enum days
    {
        monday,tuesday,wednesday,thursday,friday
    }
    public enum jobrole
    {
        teacher,
        painter,
        enginer,
        developer
    }
    public enum orderstatus
    {
        order,
        processed, 
        shipped,
        delivered,
        cashed

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            days today = days.thursday;
            Console.WriteLine(today);

            //Console.WriteLine((int)today);numeric value

            jobrole job = jobrole.teacher;
            Console.WriteLine(job);

            orderstatus order = orderstatus.processed;
            Console.WriteLine(order);
        }
    }
}
