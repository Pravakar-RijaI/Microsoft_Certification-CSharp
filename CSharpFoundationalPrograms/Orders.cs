using System;

namespace CSharpFoundation
{
    internal class OrderItem
    {
        public static void Main()
        {
            string[] OrderId = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            string[] fradulentOrders = new string[OrderId.Length];
            int i = 0;
            foreach(string item in OrderId)
            {
                if(item[0] == 'B')
                {
                    fradulentOrders[i] = item;
                    i++;
                }
                    
            }
            
            foreach(string item in fradulentOrders)
            {
                Console.WriteLine(item);
            }
        }
    }
}