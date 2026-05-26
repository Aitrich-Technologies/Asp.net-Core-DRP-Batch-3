using EX_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EX_.InterFace
{
    public interface ITourRepository
    {
        void Add(Tour tour);
        Tour[] GetAll();
        Tour GetById(int id);
        void Update(Tour tour);
    }
}
