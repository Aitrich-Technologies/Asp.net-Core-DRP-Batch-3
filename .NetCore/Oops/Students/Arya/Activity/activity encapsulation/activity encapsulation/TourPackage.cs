using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace activity_encapsulation
{
    internal class TourPackage
    {

        private string packagename;
        private int maxpeople;
        private int currentpeople;

        public void setpackage(string packagename, int maxpeople)
        {
            this.packagename = packagename;
            if (maxpeople > 0)
            {
                this.maxpeople = maxpeople;
            }
            else
            {
                this.maxpeople = 0;
            }

            currentpeople = 0;
        }
        public void addcustomer()
        {
            if (currentpeople < maxpeople)
            {
                currentpeople++;
            }


        }
        public string getpackage()
        {
            return "Package Name: " + packagename +
               "Max People: " + maxpeople +
               "Current People: " + currentpeople;
        }
    }
}