using Exercise.Interface;
using Exercise.Models;
using System;

namespace Exercise.Repositary
{
    public class ConsultantRepositary : IConsultantRepositary
    {
        Consultant[] consultants = new Consultant[10];
        int count = 0;

        public void add(Consultant consultant)
        {
            consultants[count++] = consultant;
        }

        public Consultant[] GetAll()
        {
            return consultants;
        }

        public Consultant[] GetById(int id)
        {
            Consultant[] result = new Consultant[1];

            for (int i = 0; i < count; i++)
            {
                if (consultants[i].consultantid == id)
                {
                    result[0] = consultants[i];
                    break;
                }
            }

            return result;
        }
    }
}