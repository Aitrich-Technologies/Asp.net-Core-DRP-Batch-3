using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2
{
    internal class SavingsAccount:BankAccount
    {

        public decimal InterestRate { get; set; }

        public SavingsAccount(string accNo, string holder, decimal balance, decimal rate)
            : base(accNo, holder, balance)
        {
            InterestRate = rate;
        }
        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException("Deposit amount must be positive.");
            }

            Balance += amount;
            Console.WriteLine("Amount Deposited Successfully.");
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException("Withdrawal amount must be positive.");
            }

            if (Balance - amount < 1000)
            {
                throw new InsufficientBalanceException("Minimum balance of 1000 must be maintained.");
            }

            Balance -= amount;
            Console.WriteLine("Amount Withdrawn Successfully.");
        }
    }
}

