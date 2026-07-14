using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Interface
{
    public interface IConsultantRepositary
    {
        void add(Consultant consultant);
        Consultant[] GetAll();
        Consultant[] GetById(int id);
        

    }
}
