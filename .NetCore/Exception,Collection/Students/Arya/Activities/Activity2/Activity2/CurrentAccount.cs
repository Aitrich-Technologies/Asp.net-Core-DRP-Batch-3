using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2
{
    internal class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        public CurrentAccount(string accNo, string holder, decimal balance, decimal limit)
            : base(accNo, holder, balance)
        {
            OverdraftLimit = limit;
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

            if (Balance + OverdraftLimit < amount)
            {
                throw new InsufficientBalanceException("Overdraft limit exceeded.");
            }

            Balance -= amount;
            Console.WriteLine("Amount Withdrawn Successfully.");
        }
    }
}
