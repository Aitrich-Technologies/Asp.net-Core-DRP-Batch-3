using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Models;

namespace Workshop.Interface
{
    internal interface ITourRepository
    {
        void Add(Tour t);
        Tour[] GetAll();
        Tour GetById(int id);
    }
}
