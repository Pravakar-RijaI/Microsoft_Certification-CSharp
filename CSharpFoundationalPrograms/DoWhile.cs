using System;

namespace CSharpFoundational
{
    internal class Program
    {
        public static void Main()
        {
            Random number = new Random();
            int n = 0;
            
            do
            {
                n = number.Next(1,10);
                Console.WriteLine(n);
            }while(n != 7);
        }
    }
}