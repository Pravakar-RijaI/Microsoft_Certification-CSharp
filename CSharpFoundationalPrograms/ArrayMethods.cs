using System;

namespace CSharpFoundational
{
    internal class ArrayMethods
    {
        public static void Main()
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("Sorting Array:");
            Array.Sort(pallets);
            foreach(string item in pallets)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Reverse Array:");
            Array.Reverse(pallets);
            foreach(string item in pallets)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Clearing Array:");
            Array.Clear(pallets,1,2);
            foreach(string item in pallets)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Resizing Array:");
            Console.WriteLine("Before: " + pallets.Length);
            Array.Resize(ref pallets, 6);
            Console.WriteLine("After: " + pallets.Length);
            foreach(string item in pallets)
            {
                Console.WriteLine(item);
                
            }
            
        }
    }
}