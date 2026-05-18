using System;
using System.Collections.Generic;
using System.Text;

namespace method_overloading
{
    internal class Discount
    {
       public double ApplyDiscount(double price)
        {
            return price;
        }
        public double ApplyDiscount(double price, double percent)
        {
            //total = price ;
            return price + percent;
        }
        public string ApplyDiscount(double price, double percent, string coupon)
        {
            return price + percent + coupon;
        }
    }
}
