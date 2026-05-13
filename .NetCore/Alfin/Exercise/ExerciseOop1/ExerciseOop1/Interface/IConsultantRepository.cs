using ExerciseOop1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseOop1.Interface
{
    public interface IConsultantRepository
    {
        void AddConsultant(Consultant consultant);
        Consultant[] GetAllConsultant();

        void AssignCustomer(int consultantId, int userId);

        Consultant Login(string username, string password);
    }


}
