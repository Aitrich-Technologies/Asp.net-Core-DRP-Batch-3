using Exercise.Interface;
using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Manager
{
    public class BankManager
    {
        private readonly IBankRepository repository;
      
        public BankManager(IBankRepository repository)
        {
            this.repository = repository;
        }

        public void CreateAccount(BankAccount account)
        {
            repository.AddAccount(account);

            Console.WriteLine("Account Created Successfully.");
        }
        
        public void DeleteAccount(int accountNumber)
        {
            repository.RemoveAccount(accountNumber);

            Console.WriteLine("Account Removed Successfully.");
        }
      
        public void DepositMoney(int accountNumber, decimal amount)
        {
            BankAccount account = repository.GetAccount(accountNumber);
            account.Deposit(amount);

            Console.WriteLine("Amount Deposited Successfully.");
        }

        public void WithdrawMoney(int accountNumber, decimal amount)
        {
            BankAccount account = repository.GetAccount(accountNumber);
            account.Withdraw(amount);

            Console.WriteLine("Withdrawal Successful.");
        }

        public void CheckBalance(int accountNumber)
        {
            BankAccount account = repository.GetAccount(accountNumber);

            Console.WriteLine($"Available Balance : {account.Balance}");
        }

        public void DisplayAccounts()
        {
            List<BankAccount> accounts = repository.GetAllAccounts();
            if (accounts.Count == 0)
            {
                Console.WriteLine("No Accounts Found.");
                return;
            }

            foreach (BankAccount account in accounts)
            {
                account.Display();
            }
        }
    }
}
