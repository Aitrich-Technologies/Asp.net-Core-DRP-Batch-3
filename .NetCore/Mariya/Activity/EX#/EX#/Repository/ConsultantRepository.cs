using EX_.InterFace;
using EX_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EX_.Repository
{
    public class ConsultantRepository : IConsultantRepository
    {
        private Consultant[] consultants = new Consultant[0];

        public void Add(Consultant consultant)
        {
            var newArr = new Consultant[consultants.Length + 1];

            for (int i = 0; i < consultants.Length; i++)
                newArr[i] = consultants[i];

            newArr[^1] = consultant;
            consultants = newArr;
        }

        public Consultant[] GetAll()
        {
            return (Consultant[])consultants.Clone();
        }

        public Consultant GetById(int id)
        {
            foreach (var c in consultants)
            {
                if (c.ConsultantId == id)
                    return c;
            }
            return null;
        }

        public void Update(Consultant consultant)
        {
            for (int i = 0; i < consultants.Length; i++)
            {
                if (consultants[i].ConsultantId == consultant.ConsultantId)
                {
                    consultants[i] = consultant;
                    return;
                }
            }
        }
    }
}
