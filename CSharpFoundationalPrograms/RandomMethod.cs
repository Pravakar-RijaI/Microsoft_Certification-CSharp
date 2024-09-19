using System;

namespace CSharpFoundational
{
    internal class RandomMethod
    {
        private static void CreateRandom(int n)
        {
            Random random = new Random();
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Random{i}: {random.Next(1,100)}");
            }
        }
        
        public static void Main()
        {
            CreateRandom(5);
        }
    }
}