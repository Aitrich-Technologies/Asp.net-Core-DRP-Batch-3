using System;
using System.Collections.Generic;
using System.Text;

namespace ENS
{
    internal class Calculator
    {
        public int Add(int a, int b) {
            return a+ b;
        }
        public int Add(int a, int b, int c) { 
            return a+ b + c;
        }

        public double Add(double a, double b, double c) {
            return a + b + c;
        
        }
    }
}
