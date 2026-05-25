using Exercise.Interface;
using Exercise.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        


         static void Main(string[] args)
        {
            IMenu menu =
                new PublicManager();

            menu.DisplayMenu();
        }
    }
}




