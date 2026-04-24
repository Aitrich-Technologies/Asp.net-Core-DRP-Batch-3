namespace Enum1
{
    enum days
    {
        monday, tuesday, wednesday, thursday, friday, saturday, sunday
    }

    enum jobrole
    {
        Developer,
        Accountant,
        Engineer,
        scientist
    }

    enum orderstatus
    {
        pending,
        processed,
        shipped,
        Delivered,
        Cancelled

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            days today = days.thursday;

            Console.WriteLine(today);

            //Console.WriteLine((int)today); numeric value

            jobrole role = jobrole.Developer;
            Console.WriteLine(role);

            orderstatus status = orderstatus.Cancelled;
            Console.WriteLine((int)status);
        }
  }
}
