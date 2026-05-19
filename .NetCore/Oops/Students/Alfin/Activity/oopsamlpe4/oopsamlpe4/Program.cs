namespace oopsamlpe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //student sanjay = new student();
            //sanjay.Setage(60);
            //Console.WriteLine(sanjay.Getage());

            //tour t = new tour();
            //t.Settourname("ALFIN","kerala",2000);
            //Console.WriteLine(t.Gettourname());

            //tour1 t1 = new tour1();
            //    t1.setprice(-111);
            //t1.setprice(500);
            //Console.WriteLine(t1.getprice());

            booking b = new booking();

            b.SetCustomerName("Sanjay");
            b.SetTourName("Goa Trip");
            b.SetSeats(3);
            b.ShowBooking();

            b.SetSeats(0);



            //tourpackage tp = new tourpackage("Kerala Trip", 2);

            //    tp.AddCustomer();
            //    tp.AddCustomer();
            //    tp.AddCustomer();

            //    tp.ShowDetails();


            //{
            payment p = new payment();

            p.SetAmount(500);
            p.MakePayment();

            p.SetAmount(-100);
            p.MakePayment();
            //     }


        }


        }
    
}
