using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2
{
 abstract class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accNo, string holder, decimal balance)
        {
            AccountNumber = accNo;
            AccountHolderName = holder;
            Balance = balance;
        }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);

        // Concrete Method
        public void DisplayDetails()
        {
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("Account Holder : " + AccountHolderName);
            Console.WriteLine("Balance        : " + Balance);
        }
    }


}
