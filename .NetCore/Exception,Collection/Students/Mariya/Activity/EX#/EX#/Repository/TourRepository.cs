using EX_.InterFace;
using EX_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EX_.Repository
{
    public class TourRepository : ITourRepository
    {
        private Tour[] tours = new Tour[0];

        public void Add(Tour tour)
        {
            var newArr = new Tour[tours.Length + 1];

            for (int i = 0; i < tours.Length; i++)
                newArr[i] = tours[i];

            newArr[^1] = tour;
            tours = newArr;
        }

        public Tour[] GetAll()
        {
            return (Tour[])tours.Clone();
        }

        public Tour GetById(int id)
        {
            foreach (var t in tours)
            {
                if (t.TourId == id)
                    return t;
            }
            return null;
        }

        public void Update(Tour tour)
        {
            for (int i = 0; i < tours.Length; i++)
            {
                if (tours[i].TourId == tour.TourId)
                {
                    tours[i] = tour;
                    return;
                }
            }
        }

    }
}