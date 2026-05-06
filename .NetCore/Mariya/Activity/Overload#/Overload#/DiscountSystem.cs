using System;
using System.Collections.Generic;
using System.Text;

namespace Overload_
{
    internal class DiscountSystem
    {
        public void ApplyDiscount(double price)
        {
            Console.WriteLine($"Final Price: {price}");
        }

        // Method 2 (Overloaded)
        public void ApplyDiscount(double price, double percent)
        {
            double discount = price * percent / 100;
            double finalPrice = price - discount;

            Console.WriteLine($"Final Price after {percent}% discount: {finalPrice}");
        }
        public void ApplyDiscount(double price, double percent, string coupon)
        {
            double discount = price * percent / 100;
            double finalPrice = price - discount;

            Console.WriteLine($"Final Price after {percent}% discount using coupon '{coupon}': {finalPrice}");
        }
    }
}
