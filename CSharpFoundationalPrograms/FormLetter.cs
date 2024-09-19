using System;

namespace CSharpFoundational
{
    internal class FormLetter
    {
        public static void Main()
        {
            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;
            
            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that will dramatically increase your return.\n");
            Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}. Given your current volume, your potential profit would be {newProfit:C}\n");
            Console.WriteLine("Here's a quick comparison:\n");

            string returnStr = $"{currentReturn:P}";
            string profitStr = $"{currentProfit:C}";
            string newReturnStr = $"{newReturn:P}";
            string newProfitStr = $"{newProfit:C}";
            string comparisonMessage = $"{currentProduct.PadRight(19)}{returnStr.PadRight(9)}{profitStr}\n{newProduct.PadRight(19)}{newReturnStr.PadRight(9)}{newProfitStr}";

            // Your logic here  

            Console.WriteLine(comparisonMessage);
        }
    }
}