using BankManageSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankManageSystem.Interface
{
    public interface IBankRepository
    {
        void AddAccount(BankAccount account);

        void RemoveAccount(int accountNumber);

        BankAccount GetAccount(int accountNumber);

        List<BankAccount> GetAllAccounts();
    }
}
