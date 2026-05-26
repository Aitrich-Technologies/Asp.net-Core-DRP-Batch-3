using BankManageSystem.Enums;
using BankManageSystem.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankManageSystem.Models
{
    public class BankAccount
    {
        public int AccountNumber { get; private set; }

        public string AccountHolderName { get; private set; }

        public decimal Balance { get; private set; }

        public AccountType Accounttype{ get; private set; }

       
        public BankAccount(int accountNumber,
                           string accountHolderName,
                           decimal balance,
                           AccountType accountType)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;
            Accounttype = accountType;
        }


        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposited amnt mismatch.");
                return;
            }

            Balance += amount;

            Console.WriteLine("successful.");
        }

     
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount not match.");
                return;
            }

            if (amount > Balance)
            {
                throw new InsufficientBalanceException("Insufficient balance");
            }

            Balance -= amount;

            Console.WriteLine("Withdrawal successful.");
        }

       
        public void Display()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Account Number : {AccountNumber}");
            Console.WriteLine($"Holder Name    : {AccountHolderName}");
            Console.WriteLine($"Balance        : {Balance}");
            Console.WriteLine($"Account Type   : {Accounttype}");
        }
    }
}
    

