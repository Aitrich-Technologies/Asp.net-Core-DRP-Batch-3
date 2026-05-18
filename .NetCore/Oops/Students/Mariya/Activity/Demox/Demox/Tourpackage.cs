using System;
using System.Collections.Generic;
using System.Text;

namespace Demox
{
    internal abstract class Tourpackage
    {
        public double BasePrice { get; set; }

        public abstract double CalculatePrice();
    }
}
