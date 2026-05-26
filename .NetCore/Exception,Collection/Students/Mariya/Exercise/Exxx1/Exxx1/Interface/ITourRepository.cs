using Exxx1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exxx1.Interface
{
    public interface ITourRepository
    {
        List<Tour> GetAllTours();
    }
}
