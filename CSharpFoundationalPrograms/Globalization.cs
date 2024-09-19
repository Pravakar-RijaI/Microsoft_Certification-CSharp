using System;

namespace CSharpFoundational
{
    internal class Globalization
    {
        public static void Main()
        {
            int investment = 234_234_234;
            float roi = 123_234.45f;
            decimal tax = 0.123456m;
            
            Console.WriteLine("Composite Formatting");
            Console.WriteLine("Investment: {0} Return {1}",investment,roi);
            Console.WriteLine("Investment: {0:C2} Return {1:C2}",investment,roi);
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Investment: {investment:c} Return: {roi:c}");
            Console.WriteLine("Formatting Numbers");
            Console.WriteLine($"Investment: {investment:N} Return: {roi:N4}");
            Console.WriteLine($"Tax: {tax:P1}");
            
        }
    }
}