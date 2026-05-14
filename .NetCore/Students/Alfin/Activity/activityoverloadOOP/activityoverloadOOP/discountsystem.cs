using System;
using System.Collections.Generic;
using System.Text;

namespace activityoverloadOOP
{
    internal class discountsystem
    {
        public double ApplyDiscount(double price)
        {
            return price;
        }
        public double ApplyDiscount(double price, double percent)
        {
            double discount = price * percent / 100;
            return price - discount;
        }

        
        public double ApplyDiscount(double price, double percent, string coupon)
        {
            double discount = price * percent / 100;
            double finalPrice = price - discount;

            Console.WriteLine("Coupon Applied: " + coupon);

            return finalPrice;
        }
    }
}
