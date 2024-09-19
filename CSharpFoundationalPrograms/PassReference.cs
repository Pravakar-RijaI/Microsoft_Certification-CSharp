using System;

namespace CSharpFoundational
{
    internal class PassReference
    {
        public static void Main()
        {
            int[] array = {2,4,5,76,8,6};
            PrintArray(array);
            Clear(array);
            PrintArray(array);
        }
        
        private static void PrintArray(int[] array)
        {
            foreach(int item in array)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
        
        private static void Clear(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }
    }
}