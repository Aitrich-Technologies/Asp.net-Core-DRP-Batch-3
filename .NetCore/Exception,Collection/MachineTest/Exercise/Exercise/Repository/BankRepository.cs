using Exercise.Interface;
using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Repository
{
    public class BankRepository : IBankRepository
    {
        private List<BankAccount> accounts = new List<BankAccount>();

        public void AddAccount(BankAccount account)
        {
            accounts.Add(account);
        }

        public void RemoveAccount(int accountNumber)
        {
            BankAccount account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (account == null)
            {
                throw new AccountNotFoundException("Account Not Found.");
            }
            accounts.Remove(account);
        }

        public BankAccount GetAccount(int accountNumber)
        {
            BankAccount account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (account == null)
            {
                throw new AccountNotFoundException("Account Not Found.");
            }
            return account;
        }

        public List<BankAccount> GetAllAccounts()
        {
            return accounts;
        }
    }
}
