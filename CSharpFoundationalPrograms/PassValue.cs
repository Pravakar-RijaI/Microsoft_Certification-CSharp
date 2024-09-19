using System;

namespace CSharpFoundational
{
    internal class PassValue
    {
        public static void Main()
        {
            int a = 4;
            int b = 3;
            int c = 0;
            
            Multiply(a,b,c);
            Console.WriteLine($"Inside Main: Product of: {a}x{b}={c}");
        }
        
        public static void Multiply(int a, int b, int c)
        {
            c = a * b;
            Console.WriteLine($"Inside Multiply: Product of: {a}x{b}={c}");
        }
    }
}