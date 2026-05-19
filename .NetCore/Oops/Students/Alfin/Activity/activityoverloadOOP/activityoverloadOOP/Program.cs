namespace activityoverloadOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //display1 d = new display1();
            //Console.WriteLine(d.play("alfin"));
            //Console.WriteLine(d.play("alfin"+24));

            //maths m = new maths();
            //Console.WriteLine(m.number(1));
            //Console.WriteLine(m.number(5 * 2));

            //payment p = new payment();
            //p.pay(1000);
            //p.pay(1000, "UPI");

            //booking b = new booking();
            //b.Book(2);
            //b.Book(3, "Alfin");

            searchsystem obj = new searchsystem();
            Console.WriteLine(obj.Search("hotel"));
            Console.WriteLine(obj.Search("hotel", "kochi"));


            //discountsystem ds = new discountsystem();
            //Console.WriteLine(ds.ApplyDiscount(1000));
            //Console.WriteLine(ds.ApplyDiscount(1000, 10));
            //Console.WriteLine(ds.ApplyDiscount(1000, 10, "SAVE10"));

            //employee emp = new employee();

            //Console.WriteLine(emp.CalculateSalary(10000));
            //Console.WriteLine(emp.CalculateSalary(10000, 2000));
            //Console.WriteLine(emp.CalculateSalary(10000, 2000, 1000));


            //loginsystem user = new loginsystem();

            //Console.WriteLine(user.Login("Alfin"));
            //Console.WriteLine(user.Login("Alfin", "1234"));

        }
    }
}
