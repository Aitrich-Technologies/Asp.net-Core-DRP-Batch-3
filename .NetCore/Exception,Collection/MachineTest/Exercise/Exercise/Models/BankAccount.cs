using Exercise.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Models
{
    public class BankAccount
    {
      
        public int AccountNumber { get; private set; }
        public string AccountHolderName { get; private set; }
        public AccountType AccountType { get; private set; }
        public decimal Balance { get; private set; }

 
        public BankAccount(int accountNumber, string accountHolderName, AccountType accountType, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            AccountType = accountType;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Deposit amount must be greater than zero.");
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Withdrawal amount must be greater than zero.");
            }

            if (amount > Balance)
            {
                throw new InsufficientBalanceException("Insufficient Balance.");
            }

            Balance -= amount;
        }

        public void Display()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Account Number : {AccountNumber}");
            Console.WriteLine($"Holder Name    : {AccountHolderName}");
            Console.WriteLine($"Account Type   : {AccountType}");
            Console.WriteLine($"Balance        : {Balance}");
            Console.WriteLine("--------------------------------");
        }
    }
}
