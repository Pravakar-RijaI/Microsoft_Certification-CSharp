using System;

namespace CSharpFoundational
{
    internal class Price
    {
        static double total = 0;
        static double minimumSpend = 30.00;

        static double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
        static double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};
        
        public static void Main()
        {
            for(int i = 0; i < items.Length; i++)
            {
                total += GetDiscountedPrice(i);
            }
            
            if(TotalMeetsMinimum())
                total -= 5.00;
            
            Console.WriteLine($"Total: ${FormatDecimal(total)}");
        }
        
        public static double GetDiscountedPrice(int itemIndex)
        {
            return items[itemIndex] - (items[itemIndex] * discounts[itemIndex]);
        }

        public static bool TotalMeetsMinimum()
        {
            return total > minimumSpend;
        }

        public static string FormatDecimal(double input)
        {
            return input.ToString().Substring(0,5);
        }
    }
}
