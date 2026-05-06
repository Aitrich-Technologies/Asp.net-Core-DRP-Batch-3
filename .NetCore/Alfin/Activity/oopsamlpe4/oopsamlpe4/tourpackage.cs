using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace oopsamlpe4
{
    internal class tourpackage
    {
        private string packageName;
        private int maxPeople;
        private int currentPeople;


        public tourpackage(string name, int max)
        {
            packageName = name;
            maxPeople = max;
            currentPeople = 0;
        }

        public void AddCustomer()
        {
            if (currentPeople < maxPeople)
            {
                currentPeople++;
                Console.WriteLine("Customer added : " + currentPeople);
            }
            else
            {
                Console.WriteLine("Cannot add more customers. Package is full!");
            }
        }

        
        public void ShowDetails()
        {
            Console.WriteLine("Package: " + packageName);
            Console.WriteLine("Max People: " + maxPeople);
            Console.WriteLine("Current People: " + currentPeople);
        }
    }
}


    

