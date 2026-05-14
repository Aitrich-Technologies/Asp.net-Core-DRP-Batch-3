using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise2.Models;

namespace Excercise2.Interface
{
    public interface IConsultantManager:IManager
    {
        void AddTour(Tour tour);
        void ViewTour();
        void DestinationMenu();
    }
}
