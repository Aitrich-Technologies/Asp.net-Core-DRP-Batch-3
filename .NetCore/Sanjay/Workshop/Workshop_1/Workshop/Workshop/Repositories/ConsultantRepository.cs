using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Interface;
using Workshop.Models;

namespace Workshop.Repositories
{
    internal class ConsultantRepository : IConsultantRepository
    {
        private Consultant[] consultants = new Consultant[0];

        public void Add(Consultant c)
        {
            var newArr = new Consultant[consultants.Length + 1];
            for (int i = 0; i < consultants.Length; i++)
                newArr[i] = consultants[i];

            newArr[consultants.Length] = c;
            consultants = newArr;
        }

        public Consultant[] GetAll() => consultants;

        public Consultant GetById(int id)
        {
            foreach (var c in consultants)
                if (c.ConsultantId == id) return c;
            return null;
        }
    }
}
