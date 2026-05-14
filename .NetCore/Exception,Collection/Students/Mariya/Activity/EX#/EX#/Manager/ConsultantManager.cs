using EX_.InterFace;
using EX_.Models;
using EX_.Participants;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Text;

namespace EX_.Manager
{
    public class ConsultantManager
    {
        private readonly IConsultantRepository _repo;
        private int _idCounter = 1;

        public ConsultantManager(IConsultantRepository repo)
        {
            _repo = repo;
        }

        public void AddConsultant(string name, int userId)
        {
            _repo.Add(new Consultant
            {
                ConsultantId = _idCounter++,
                Name = name,
                AssignedCustomers = new int[0]
            });
        }

        public Consultant[] ViewConsultants()
        {
            return _repo.GetAll();
        }

        public void AssignCustomer(int consultantId, int customerId)
        {
            var consultant = _repo.GetById(consultantId);
            if (consultant == null) return;

            var newArray = new int[consultant.AssignedCustomers.Length + 1];

            for (int i = 0; i < consultant.AssignedCustomers.Length; i++)
                newArray[i] = consultant.AssignedCustomers[i];

            newArray[^1] = customerId;

            consultant.AssignedCustomers = newArray;
            _repo.Update(consultant);
        }
    }
}
