using System;
using System.Collections.Generic;
using System.Text;

namespace EH3

{
    abstract class BankAC

    {
        public string accountnumber { get; set; }
        public string holdername { get; set; }
        public decimal balance { get; set; }





        public BankAC(string accNo, string name, decimal bal)
        {
            accountnumber = accNo;
            holdername = name;
            balance = bal;
        }


        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);


        public void Display()
        {
            Console.WriteLine("\nAccount No : " + accountnumber);
            Console.WriteLine("Name       : " + holdername);
            Console.WriteLine("Balance    : ₹" + balance);
        }
    }
}









    

