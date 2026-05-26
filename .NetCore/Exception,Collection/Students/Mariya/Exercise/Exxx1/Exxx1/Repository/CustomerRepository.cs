using Exxx1.Exceptions;
using Exxx1.Interface;
using Exxx1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exxx1.Repository
{
    public class CustomerRepository:ICustomerRepository
    {

        private static List<Customer> customers = new List<Customer>();

        public void Register(Customer customer)
        {
            var existingCustomer =
                customers.FirstOrDefault(c => c.Email == customer.Email);

            if (existingCustomer != null)
            {
                throw new UserAlreadyExistsException(
                    "Customer with this email already exists."
                );
            }

            customers.Add(customer);
        }

        public Customer Login(string email, string password)
        {
            return customers.FirstOrDefault(
                c => c.Email == email && c.Password == password);
            
        }

        public List<Customer> GetAllCustomers()
        {
            return customers;
        }
    }
}
