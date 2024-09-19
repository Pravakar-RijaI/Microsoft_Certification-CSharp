using System;

namespace CSharpFoundational
{
    internal class Cast
    {
        public static void Main()
        {
            float num = 0, total = 0;
            string alphabets = "";
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };
        
            for(int i = 0; i < values.Length; i++)
            {
                if(float.TryParse(values[i],out num))
                {
                    total += num;
                }
                else
                {
                    alphabets += values[i];
                }
                
            }
            
            Console.WriteLine("Message: " + alphabets);
            Console.WriteLine("Total: " + total);
            
        }
    }
}