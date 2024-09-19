using System;

namespace CSharpFoundational
{
    internal class GmtParams
    {
        public static void Main()
        {
            int[] schedule = {800, 1200, 1600, 2000};
            Console.WriteLine("Enter your current GMT: ");
            int currentGmt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your new Gmt: ");
            int newGmt = Convert.ToInt32(Console.ReadLine());
            DisplayAdjustedTimes(schedule,currentGmt,newGmt);
        }
        
        public static void DisplayAdjustedTimes(int[] schedule, int currentGmt, int newGmt)
        {
            int diff = 0;
            
            if(currentGmt > 12 || newGmt > 12)
                Console.WriteLine("Invalid GMT..");
            else if(currentGmt > 0 && newGmt > 0 || currentGmt < 0 && newGmt < 0)
                diff = 100 * (Math.Abs(newGmt) - Math.Abs(currentGmt));
            else
                diff = 100 * (Math.Abs(newGmt) + Math.Abs(currentGmt));
                
            foreach(int time in schedule)
            {
                string gmtTime = ((time + diff) % 2400).ToString();
                
                if(gmtTime.Length >= 3)
                    Console.Write(gmtTime.Insert(gmtTime.Length - 2,":") + "\t");
                else if(gmtTime.Length == 2)
                    Console.Write(gmtTime.Insert(0,"0") + "\t");
                else
                    Console.Write(gmtTime.Insert(0,"0:0") + "\t");
            }
            
        }
    }
}