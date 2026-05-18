using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverloading_activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Displayinfo d = new Displayinfo();
            d.Display("ARYA");
            d.Display("Arya", 22);

            Areacalculator A = new Areacalculator();
            A.area(5);
            A.area(6, 8);

            Payment p = new Payment();
            p.pay(2000);
            p.Pay(2000, "UPI");

            Booking B = new Booking();
            B.Book(2);
            B.Book(2, "Sanjay");

            Search s = new Search();
            s.search("Tour");
            s.search("Tour", "Bali");

            Employee e = new Employee();
            e.CalculateSalary(20000);
            e.CalculateSalary(20000, 5000);
            e.CalculateSalary(20000, 5000, 2000);

            Login l = new Login();
            l.login("Arya");
            l.login("Arya", "1234");

        }
    }
}
