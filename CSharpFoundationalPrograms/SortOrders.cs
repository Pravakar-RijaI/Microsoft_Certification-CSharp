using System;

namespace CSharpFoundational
{
    internal class SortOrders
    {
        public static void Main()
        {
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] Order = orderStream.Split(',');
            Array.Sort(Order);
            for(int i = 0; i < Order.Length; i++)
            {
                if(Order[i].ToCharArray().Length == 4)
                {
                    Console.WriteLine(Order[i]);
                }
                else
                {
                    Console.WriteLine(Order[i] + "\t- Error");
                }
            }
        }
    }
}