using BankManageSystem.Exceptions;
using BankManageSystem.Interface;
using BankManageSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankManageSystem.Managers
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

            Console.WriteLine("Account creation Completed.");
        }

     
        public void DeleteAccount(int accountNumber)
        {
            try
            {
                repository.RemoveAccount(accountNumber);

                Console.WriteLine("Account unavailable.");
            }
            catch (AccountNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    
        public void DepositMoney(int accountNumber, decimal amount)
        {
            try
            {
                BankAccount account = repository.GetAccount(accountNumber);

                account.Deposit(amount);
            }
            catch (AccountNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

      
        public void WithdrawMoney(int accountNumber, decimal amount)
        {
            try
            {
                BankAccount account = repository.GetAccount(accountNumber);

                account.Withdraw(amount);
            }
            catch (AccountNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

 
        public void CheckBalance(int accountNumber)
        {
            try
            {
                BankAccount account = repository.GetAccount(accountNumber);

                Console.WriteLine($"Current Balance: {account.Balance}");
            }
            catch (AccountNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

  
        public void DisplayAllAccounts()
        {
            var accounts = repository.GetAllAccounts();

            if (accounts.Count == 0)
            {
                Console.WriteLine("No accounts available.");
                return;
            }

            foreach (var account in accounts)
            {
                account.Display();
            }
        }
    }
}
       
        
    


