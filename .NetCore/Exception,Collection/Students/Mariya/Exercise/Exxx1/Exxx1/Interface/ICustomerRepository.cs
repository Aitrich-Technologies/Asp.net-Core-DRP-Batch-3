using Exxx1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exxx1.Interface
{
    public interface ICustomerRepository
    {
        void Register(Customer customer);

        Customer Login(string email, string password);

        List<Customer> GetAllCustomers();
    }
}
