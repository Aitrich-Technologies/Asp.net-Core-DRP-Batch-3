using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ACTIVITY
{
    internal class Vehicle
    {
        public string Make;
        public string Model;
        public int Year;
        private string Registrationnumber;

        public Vehicle (string make, string model, int year, string regNo)
        {
            Make = make;
            Model = model;
            Year = year;
            Registrationnumber = regNo;
        }



    }
    }

