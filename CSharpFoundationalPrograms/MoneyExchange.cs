using System;

namespace CSharpFoundational
{
    internal class MoneyExchange
    {
        public static void Main()
        {
            double usd = 23.73;
            int vnd = UsdToVnd(usd);

            Console.WriteLine($"${usd} USD = ${vnd} VND");
            Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");
            
        }
        
        public static int UsdToVnd(double usd) 
        {
            return (int) (usd * 23500);
        }
        
        public static double VndToUsd(int vnd)
        {
            return vnd / 23500.00;
        }
    }
}
