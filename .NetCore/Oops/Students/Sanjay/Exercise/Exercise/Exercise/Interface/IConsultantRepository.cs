using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Interface
{
    public interface IConsultantRepository
    {
        void AddConsultant(Consultant consultant);
        Consultant[] GetAllConsultant();

        void AssignCustomer(int consultantId, int userId);

        Consultant Login(string username, string password);
    }
}
