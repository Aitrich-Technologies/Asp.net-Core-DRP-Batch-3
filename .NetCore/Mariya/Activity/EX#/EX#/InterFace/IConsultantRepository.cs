using EX_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EX_.InterFace
{
   public interface IConsultantRepository
    {

        void Add(Consultant consultant);
        Consultant[] GetAll();
        Consultant GetById(int id);
        void Update(Consultant consultant);
    }
}
