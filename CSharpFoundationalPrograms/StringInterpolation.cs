using System;

namespace CSharpFoundational
{
    internal class stringInterpolation
    {
        public static void Main()
        {
            int invoiceNumber = 1201;
            decimal productShares = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal taxPercentage = .15825m;
            decimal total = 3185.19m;

            Console.WriteLine($"Invoice Number: {invoiceNumber}");
            Console.WriteLine($"\tShares: {productShares:N3} Product");
            Console.WriteLine($"\t\tSub Total: {subtotal:C}");
            Console.WriteLine($"\t\t\tTax: {taxPercentage:P}");
            Console.WriteLine($"\t\t\t\tTotal Billed: {total:C}");
        }
    }
    
}