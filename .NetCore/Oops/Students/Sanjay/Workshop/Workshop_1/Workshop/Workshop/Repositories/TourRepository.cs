using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Interface;
using Workshop.Models;

namespace Workshop.Repositories
{
    internal class TourRepository : ITourRepository
    {
        private Tour[] tours = new Tour[0];

        public void Add(Tour t)
        {
            var newArr = new Tour[tours.Length + 1];
            for (int i = 0; i < tours.Length; i++)
                newArr[i] = tours[i];

            newArr[tours.Length] = t;
            tours = newArr;
        }

        public Tour[] GetAll() => tours;

        public Tour GetById(int id)
        {
            foreach (var t in tours)
                if (t.TourId == id) return t;
            return null;
        }
    }
}
