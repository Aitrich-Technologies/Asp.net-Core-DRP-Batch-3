using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Models;

namespace Workshop.Interface
{
    internal interface IConsultantRepository
    {
        void Add(Consultant c);
        Consultant[] GetAll();
        Consultant GetById(int id);
    }
}
