using System;
using System.Collections.Generic;
using System.Text;

namespace ENS
{
    internal class Tour_package
    {
        class TourPackage
        {
            private string packageName;
            private int maxPeople;
            private int currentPeople;

            // Constructor
            public TourPackage(string name, int max)
            {
                packageName = name;
                maxPeople = max;
                currentPeople = 0;
            }

            // Getter methods
            public string GetPackageName()
            {
                return packageName;
            }

            public int GetMaxPeople()
            {
                return maxPeople;
            }

            public int GetCurrentPeople()
            {
                return currentPeople;
            }

            // Method to add customer
            public bool AddCustomer()
            {
                if (currentPeople < maxPeople)
                {
                    currentPeople++;
                    return true;
                }
                else
                {
                    Console.WriteLine("Cannot add customer: Package is full.");
                    return false;
                }
            }

            // Display method (optional but useful)
            public void DisplayDetails()
            {
                Console.WriteLine($"Package: {packageName}");
                Console.WriteLine($"Capacity: {currentPeople}/{maxPeople}");
            }
        }
    }
}
