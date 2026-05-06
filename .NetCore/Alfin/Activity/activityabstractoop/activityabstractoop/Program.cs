using System.Transactions;

namespace activityabstractoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tour t;
            t = new domestictour1
            {
                id = 1
            };
            t.ShowDetails();

            t = new internationaltour1
            {
                name = "paris"
            };
            t.ShowDetails();

            //2

            payment2 p;
            p = new cardpayment2()
            {
                amount = 1000,
                paymentdate = "22/12/2001",
                transactionid = "tx123",
                cardnumber = "123-456",
                cardholdername = "alfin"
            };

            p.MakePayment();

            p = new upipayment2()
            {
                amount = 2000,
                paymentdate = "22/3/2001",
                transactionid = "tx1245",
                UPIId = "alfin12"
            };

            p.MakePayment();

            //3

            tourpackage3 to;
            to = new LuxuryPackage3()
            {
                baseprice = 1000,
                luxuryprice = 300
            };
            to.CalculatePrice();
            Console.WriteLine("Luxury Price:" + to.CalculatePrice());

            to = new BudgetPackage3()
            {
                baseprice = 1000,
                budgetprice = 200
            };
            to.CalculatePrice();
            Console.WriteLine("Budget Price:" + to.CalculatePrice());

            //4

            Transport4 tr;
            tr = new bus4();
            tr.Travel();
            tr = new train4();
            tr.Travel();
            tr = new flight4();
            tr.Travel();

            //5

            hotel5 h;
            h = new standardroom5();
           

            h.Bookroom();
            h = new deluxeroom5();
            h.Bookroom();

            //6

            guide6 g;
            g = new cityguide6();
            g.ExplainPlace();
            g=new adventureguide6();
            g.ExplainPlace();
        }
    }
}
