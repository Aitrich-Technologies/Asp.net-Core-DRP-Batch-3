using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Interface;
using Workshop.Models;

namespace Workshop.Managers
{
    internal class ConsultantManager
    {
        private IConsultantRepository repo;

        public ConsultantManager(IConsultantRepository repo)
        {
            this.repo = repo;
        }

        public void AddConsultant(string name)
        {
            repo.Add(new Consultant
            {
                ConsultantId = new Random().Next(1000),
                Name = name,
                AssignedCustomers = 0
            });
        }

        public Consultant[] ViewConsultants() => repo.GetAll();

        public void AssignCustomer(int id)
        {
            var c = repo.GetById(id);
            if (c != null)
                c.AssignedCustomers++;
        }
    }
}
