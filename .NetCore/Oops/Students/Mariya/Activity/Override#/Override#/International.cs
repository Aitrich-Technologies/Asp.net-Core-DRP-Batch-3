using System;
using System.Collections.Generic;
using System.Text;

namespace Override_
{
    internal class International:Tour
    {

        public int Days { get; set; }
        public double CostPerDay { get; set; }
        public double VisaFee { get; set; }

        public International(int days, double costPerDay, double visaFee)
        {
            Days = days;
            CostPerDay = costPerDay;
            VisaFee = visaFee;
        }

        public override double CalculatePrice()
        {
            return (Days * CostPerDay) + VisaFee;
        }

    }
}
